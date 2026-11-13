
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;
namespace haiandro
{
	internal static class Program
	{
		/// <summary>
		/// ここがアプリのスタート地点
		/// </summary>
		[STAThread]
		static void Main()
		{
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var connectionString = "Data Source=test.db";

			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var sql = @"
						CREATE TABLE IF NOT EXISTS Battle_History (
							id INTEGER NOT NULL,
							point INTEGER NOT NULL,
							Date TEXT NOT NULL
						);";

			using var command = new SqliteCommand(sql, connection);
			command.ExecuteNonQuery();

			/*
			// データ追加
			sql = "INSERT INTO Battle_History (id, point, Date) VALUES (@id, @point, @Date)";
			using var command1 = new SqliteCommand(sql, connection);

			string today = DateTime.Now.ToString("yyyy-MM-dd");

			command1.Parameters.AddWithValue("@id", 1);
			command1.Parameters.AddWithValue("@point", 25);
			command1.Parameters.AddWithValue("@Date", today);

			command1.ExecuteNonQuery();
			*/

			
			// データ読み込み
			sql = "SELECT COUNT(*) FROM Battle_History";

			using var command2 = new SqliteCommand(sql, connection);
			using var reader = command2.ExecuteReader();

			while (reader.Read())
			{
				var id = reader.GetInt32(0);

				Console.WriteLine($"{id}");
			}
			

			ApplicationConfiguration.Initialize();
			Application.Run(new Title());
		}
	}
}