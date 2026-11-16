
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data;
using static haiandro.AI;
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

            // 1. 保存したいフォルダのパスを組み立てる（例: exeと同じ階層にある「Data」フォルダ）
            string folderPath = Path.Combine(Application.StartupPath, "Data");

            // 2. フォルダが存在しない場合は自動で作成する（※これがないとエラーになります）
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // 3. データベースファイルのフルパスを作成
            string dbPath = Path.Combine(folderPath, "History.db");

            var connectionString = $"Data Source={dbPath}";

			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var sql = @"
						CREATE TABLE IF NOT EXISTS Battle_History (
							id INTEGER NOT NULL,
							point INTEGER NOT NULL,
							mode TEXT NOT NULL,
							battle_set INTEGER NOT NULL,
							date TEXT NOT NULL
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
			sql = "SELECT COUNT(id) FROM Battle_History";

			using var command2 = new SqliteCommand(sql, connection);
			using var reader = command2.ExecuteReader();

			while (reader.Read())
			{
				var id = reader.GetInt32(0);
			}

			
            string modelPath = "model.zip";

            // 初回のみ学習を実行してモデルを作成
            if (!File.Exists(modelPath))
            {
				Console.WriteLine(">>学習データを作成しています...");
                ModelTrainer.TrainAndSaveModel(modelPath);
                Console.WriteLine(">>学習データを作成しました！");
            }
			/*
            // AIを初期化
            var ai = new HighLowAiPredictor(modelPath);

            // 例：場に「7」が出ていて、山札に高いカードが18枚、低いカードが10枚残っている状況
            bool isHigher = ai.ShouldBetHigh(currentCard: 7, remainingHighCount: 18, remainingLowCount: 10);

            Console.WriteLine($"7より高いか？ -> {isHigher}"); // true が返る
			*/

            ApplicationConfiguration.Initialize();
			Application.Run(new Title());
		}
	}
}