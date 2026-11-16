using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace haiandro
{
	public partial class History : Form
	{
		public History()
		{
			InitializeComponent();
			dataGridView1.Rows.Clear();
			dataGridView1.AutoGenerateColumns = true;

			// 1. 保存したいフォルダのパスを組み立てる（例: exeと同じ階層にある「Data」フォルダ）
			string folderPath = Path.Combine(Application.StartupPath, "Data");
			string dbPath = Path.Combine(folderPath, "History.db");

			// 2. フォルダが存在しない場合は自動で作成する（※これがないとエラーになります）
			if (!File.Exists(dbPath))
			{
				MessageBox.Show("まだ記録が残っていません。", "データ不在", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			// 3. データベースファイルのフルパスを作成
			var connectionString = $"Data Source={dbPath}";

			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var sql = "SELECT * FROM Battle_History";

			using var command2 = new SqliteCommand(sql, connection);
			using var reader = command2.ExecuteReader();

			while (reader.Read())
			{
				var id = reader.GetInt32(0);
				var point = reader.GetInt32(1);
				var mode = reader.GetString(2);
				var battle_count = reader.GetInt32(3);
				var date = reader.GetString(4);
				dataGridView1.Rows.Add(id, point, mode, battle_count, date);
			}
		}

		private void Cell_Click(object sender, DataGridViewCellEventArgs e)
		{
			// 1. 列ヘッダー（一番上の見出し行）がクリックされた場合は何もしない
			if (e.RowIndex < 0)
			{
				return;
			}

			// 2. クリックされた行を取得
			DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
		}
	}
}
