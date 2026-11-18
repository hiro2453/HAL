using Microsoft.Data.Sqlite;
using NAudio.Wave;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace haiandro
{
	public partial class Game : Form
	{
		//ウィンドウを閉じたかの確認用
		bool Form_end = false;
		bool End_Game = false;
		Deck d = new Deck();
		int battle_Count = 0;
		int now_battle = 0;
		bool Answer = false;
		bool High = false;
		bool Low = false;
		int Data_id = 0;
		string controlName = "";
		bool win = false;
		bool lose = false;
		bool drow = false;
		bool timeup = false;
		bool Endless = false;
		int card_count = 0;
        AudioFileReader Audio_win = new AudioFileReader(Properties.Resources.Win_audio);
        AudioFileReader Audio_lose = new AudioFileReader(Properties.Resources.Lose_audio);
        AudioFileReader Audio_draw = new AudioFileReader(Properties.Resources.Draw_audio);
        WaveOut AW = new WaveOut();
        WaveOut AL = new WaveOut();
        WaveOut AD = new WaveOut();

        public Game(bool END,bool AI)
		{
			Properties.Settings.Default.Warning_text = false;
			Endless= END;

			AW.Init(Audio_win);
			AL.Init(Audio_lose);
			AD.Init(Audio_draw);
            

            #region IDを確定させるためのSQL
            // 1. フォルダを指定 -> ファイル名確定 ->SQLiteにdbファイルを指定 -> 接続
            string folderPath = Path.Combine(Application.StartupPath, "Data");
			string dbPath = Path.Combine(folderPath, "History.db");
			var connectionString = $"Data Source={dbPath}";
			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			//2.SQL文
			var sql = "SELECT COUNT(id) FROM Battle_History";

			//3.SQL文を実行
			using var command = new SqliteCommand(sql, connection);
			using var reader = command.ExecuteReader();

			//4.出力された列データをひとつずつ読み込み
			while (reader.Read())
			{
				Data_id = reader.GetInt32(0);
			}

			//5.もう使わないのでファイルクローズ
			connection.Close();

			#endregion

			#region 試合の詳細を記録するためのSQL
			//1.試合データ作成
			dbPath = Path.Combine(folderPath, $"{Data_id+1}.db");

			if (File.Exists(dbPath))
			{
				File.Delete(dbPath);
			}

			connectionString = $"Data Source={dbPath}";
			using var connection2 = new SqliteConnection(connectionString);
			connection2.Open();

			//2.SQL文
			sql = @"CREATE TABLE Battle_detail (
						bc	INTEGER NOT NULL,
						Guess	TEXT NOT NULL,
						Result	TEXT NOT NULL,
						Left_Card	INTEGER NOT NULL,
						Right_Card	INTEGER NOT NULL,
						select_time	TEXT NOT NULL
					);";

			//3.テーブル作成
			using var command2 = new SqliteCommand(sql, connection2);
			command2.ExecuteNonQuery();
			connection2.Close();

			#endregion

			InitializeComponent();
			Result_Table.Visible = true;

			d.Shuffle();
			d.Card_kure();
			card_display();
			card_num1.Text = d.What_number();
			Start();
		}

		#region 勝負開始
		public async void Start()
		{
			if (Form_end)
			{
				//ウィンドウが閉じられたら処理を実行しないように
				Console.WriteLine("ウィンドウ閉じられたからもう処理を行わないよ");
				return;
			}

			card_count = int.Parse(d.What_AllCard());
			if(card_count == 0)
			{
				d.Shuffle();
				Console.WriteLine("[デバッグ] > カードが無くなったため、追加で補完しました");
			}

			now_battle++;
			win = false;
			lose = false;
			drow = false;
			High = false;
			Low = false;
			timeup = false;
			Answer = false;
			countdown();
            if (!Endless)
            {
                if (Properties.Settings.Default.Deck_option)
                {
                    battle_Count = Properties.Settings.Default.set * 51;
                }
                if (Properties.Settings.Default.Card_ALLCount)
                {
                    battle_Count = Properties.Settings.Default.set;
                }
                Battle_AllCount_label.Text = battle_Count.ToString();
                battle_Count_label.Text = now_battle.ToString();
            }
            else
            {
                battle_Count_label.Visible = false;
                battle_Slash.Text = "エンドレスモード";
                Battle_AllCount_label.Visible = false;
                battle_kaime.Visible = false;
            }
		}
		#endregion

		#region カウントダウン処理
		private async void countdown()
		{
			Timer_table.Visible = true;
			Action_table.Visible = true;
			progressBar1.Value = 0;
			label1.Text = "5.0";
			card_num2.Text = "？";
			Answer_label.Text = "どっち？";
			string value = progressBar1.Value.ToString();
			char[] test = value.ToCharArray();
			string text = "";
			card_num1.Text = d.What_number();

			while (progressBar1.Value < progressBar1.Maximum)
			{
				if (Answer == true)
				{
					break;
				}
				await Task.Delay(100);
				value = progressBar1.Value.ToString();
				test = value.ToCharArray();
				if (progressBar1.Value < 10)
				{
					text = $"0.{test[0]}";
				}
				else
				{
					text = $"{test[0]}.{test[1]}";
				}
				label1.Text = (5.0m - decimal.Parse(text)).ToString();
				progressBar1.Value++;
			}

			if (Answer == true)
			{
				return;
			}

			if (Form_end)
			{
				//ウィンドウが閉じられたら処理を実行しないように
				Console.WriteLine("ウィンドウ閉じられたからもう処理を行わないよ");
				return;
			}

			await Task.Delay(100);
			label1.Text = "0.0";
			progressBar1.Visible = false;
			Answer_label.Text = "時間切れ";
			Action_table.Visible = false;
			timeup = true;

			await Task.Delay(1000);
			await Card_rool();
			return;
		}
		#endregion

		#region カードを表示する処理
		private void card_display()
		{
			string image_name = d.Card_kure();
			Image img = Properties.Resources.ResourceManager.GetObject(image_name) as Image;
			Left_Card.Image = img;
			card_num1.Text = d.What_number();
		}
		#endregion

		#region 「High」か「Low」を押した処理
		private void button_Click(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				// デザイナーで設定した (Name) を取得
				controlName = control.Text;
				Console.WriteLine(controlName);

				switch (controlName)
				{
					case "High": High = true; break;
					case "Low": Low = true; break;
				}
				battle();
				Console.WriteLine($">>{High}");
				Console.WriteLine($">>{Low}");
				Answer_label.Text = controlName;
			}

		}
		#endregion

		#region トランプをめくるアニメーション
		private async Task Card_rool()
		{
			//トランプをめくるアニメーション
			int Width = 150;

			while (Right_Card.Size.Width > 5)
			{
				Width -= 10;
				await Task.Delay(15);
				Right_Card.Size = new Size(Width, 220);
			}

			string image_name = d.Card_kure();
			Console.WriteLine(image_name);
			Image img = Properties.Resources.ResourceManager.GetObject(image_name) as Image;
			Right_Card.Image = img;

			while (Right_Card.Size.Width < 150)
			{
				Width += 10;
				await Task.Delay(15);
				Right_Card.Size = new Size(Width, 220);
			}

			card_num2.Text = d.What_number();
			await Task.Delay(3000);
			await Move_card(Right_Card.Image);
			if (int.Parse(Battle_AllCount_label.Text) == int.Parse(battle_Count_label.Text))
			{
				await Game_end();
				return;
			}
			Start();
		}
		#endregion

		#region 勝負する処理
		private async void battle()
		{

			//色々な処理
			Answer = true;
			Timer_table.Visible = false;
			Action_table.Visible = false;

			//アニメーション用変数宣言
			int x = 450;
			info_label.Location = new Point(x, 30);
			info_label.Visible = true;

			//アニメーション
			while (info_label.Location.X > 150)
			{
				await Task.Delay(10);
				info_label.Location = new Point(x, 30);

				x -= 15;
			}

			await Task.Delay(1500);

			while (info_label.Location.X > -150)
			{
				await Task.Delay(10);
				info_label.Location = new Point(x, 30);
				x -= 15;
			}

			await Task.Delay(1000);

			//トランプをめくるアニメーション
			int Width = 150;

			while (Right_Card.Size.Width > 5)
			{
				Width -= 10;
				await Task.Delay(15);
				Right_Card.Size = new Size(Width, 220);
			}
			string image_name = d.Card_kure();
			Image img = Properties.Resources.ResourceManager.GetObject(image_name) as Image;
			Right_Card.Image = img;

			while (Right_Card.Size.Width < 150)
			{
				Width += 10;
				await Task.Delay(15);
				Right_Card.Size = new Size(Width, 220);
			}

			card_num2.Text = d.What_number();

			//引き分けかの判定
			if (int.Parse(card_num1.Text) == int.Parse(card_num2.Text))
			{
				await Result_display('d');
			}
			else
			{
				//Highを選んだ時の処理
				if (High == true)
				{
					if (int.Parse(card_num1.Text) < int.Parse(card_num2.Text))
					{
						Console.WriteLine($"[デバック]あなたの勝ちです");
						await Result_display('w');
					}
					else
					{
						Console.WriteLine($"[デバック]あなたの負けです");
						await Result_display('l');
					}
				}

				//Lowを選んだ時の処理
				if (Low == true)
				{
					if (int.Parse(card_num1.Text) > int.Parse(card_num2.Text))
					{
						Console.WriteLine($"[デバック]あなたの勝ちです");
						await Result_display('w');
					}
					else
					{
						Console.WriteLine($"[デバック]あなたの負けです");
						await Result_display('l');
					}
				}
			}

			string folderPath = Path.Combine(Application.StartupPath, "Data");
			var dbPath = Path.Combine(folderPath, $"{Data_id + 1}.db");
			var connectionString = $"Data Source={dbPath}";
			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			var sql = "INSERT INTO Battle_detail (bc,Guess,Result,Left_Card,Right_Card,select_time) VALUES (@bc, @Guess, @Result, @Left_Card, @Right_Card, @select_time)";
			using var command = new SqliteCommand(sql, connection);

			command.Parameters.AddWithValue("@bc", int.Parse(battle_Count_label.Text));
			if (timeup)
			{
				command.Parameters.AddWithValue("@Guess", "未選択");
			}
			else
			{
				command.Parameters.AddWithValue("@Guess", controlName);
			}


			if (win)
			{
				command.Parameters.AddWithValue("@Result", "勝ち");
			}
			if (lose)
			{
				command.Parameters.AddWithValue("@Result", "負け");
			}
			if (drow)
			{
				command.Parameters.AddWithValue("@Result", "ひきわけ");
			}

			command.Parameters.AddWithValue("@Left_Card", int.Parse(card_num1.Text));
			command.Parameters.AddWithValue("@Right_Card", int.Parse(card_num2.Text));

			if (timeup)
			{
				command.Parameters.AddWithValue("@select_time", "時間切れ");
			}
			else
			{
				command.Parameters.AddWithValue("@select_time", (5.0 - double.Parse(label1.Text)).ToString());
			}


			command.ExecuteNonQuery();

			await Task.Delay(1000);

			if (int.Parse(Battle_AllCount_label.Text) == int.Parse(battle_Count_label.Text))
			{
				await Game_end();
				return;
			}

            if (Endless && lose)
            {
                await Game_end();
                return;
            }

            await Move_card(Right_Card.Image);
			Start();
		}
		#endregion

		private async Task Game_end()
		{
			Answer_label.Visible = true;
			Answer_label.Text = "試合終了！";
			await Task.Delay(1000);

			//データベース接続
			string folderPath = Path.Combine(Application.StartupPath, "Data");
			string dbPath = Path.Combine(folderPath, "History.db");
			var connectionString = $"Data Source={dbPath}";
			using var connection = new SqliteConnection(connectionString);
			connection.Open();

			//変数用意
			string sql;
			int id = 0;

			//id列にいくつ行が何個あるかカウント
			sql = "SELECT COUNT(id) FROM Battle_History";

			using var command2 = new SqliteCommand(sql, connection);
			using var reader = command2.ExecuteReader();

			while (reader.Read())
			{
				id = reader.GetInt32(0);
			}

			//データベース処理
			sql = "INSERT INTO Battle_History (id, point, mode, battle_set, date) VALUES (@id, @point, @mode, @set, @date)";
			using var command = new SqliteCommand(sql, connection);

			string today = DateTime.Now.ToString("yyyy-MM-dd");

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id + 1);
			command.Parameters.AddWithValue("@point", int.Parse(Point_label.Text));

			if (!Endless)
			{
				command.Parameters.AddWithValue("@mode", "シングルプレイ");
			}
			else
			{
				command.Parameters.AddWithValue("@mode", "エンドレス");
			}

			command.Parameters.AddWithValue("@set", Properties.Settings.Default.set);
			command.Parameters.AddWithValue("@date", today);

			command.ExecuteNonQuery();

			if (!Endless)
			{
				MessageBox.Show($"設定試合数まで達しました。\n\nポイント：{Point_label.Text}\n保存日時：{today}\n\nOKを押すとタイトル画面に戻ります。", "結果発表", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			else
			{
				MessageBox.Show($"予想が外れたため終了です。\n\nポイント：{Point_label.Text}\n保存日時：{today}\n\nOKを押すとタイトル画面に戻ります。", "結果発表", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			
			Properties.Settings.Default.ID++;
			Properties.Settings.Default.Save();
			End_Game = true;
			this.Close();
			return;
		}

		#region 「あたり」「はずれ」「ドロー」を表示する処理
		private async Task Result_display(char Check)
		{
			Result_Table.Visible = true;
			Result_Table.BringToFront();
            

            switch (Check)
			{
				case 'w':
					AW.Play();
					Result_img.Image = Properties.Resources.WIN;
					win = true;
                    Point_label.Text = (int.Parse(Point_label.Text) + 1).ToString();
                    break;
				case 'l':
					AL.Play();
					Result_img.Image = Properties.Resources.LOSE;
                    lose = true;
					break;
				case 'd':
					AD.Play();
					Result_img.Image = Properties.Resources.DRAW;
                    drow = true;
					break;
			}
			Result_img.Visible = true;
            Result_img.Size = new Size(120, 0);
			int Width = 0;

            while (Result_img.Size.Height < 55)
			{
				Width += 5;
				await Task.Delay(30);
				Result_img.Size = new Size(120, Width);
			}

			await Task.Delay(2000);

			while (Result_img.Size.Height > 0)
			{
				Width -= 5;
				await Task.Delay(30);
				Result_img.Size = new Size(120, Width);
			}
		}
		#endregion

		#region 右のカードを左に移動する処理
		private async Task Move_card(Image img)
		{
			move_pic.Image = img;
			move_pic.Location = new Point(227, 132);
			move_pic.Visible = true;
			Right_Card.Image = Properties.Resources.card_back;
			int x = 227;

			while (move_pic.Location.X > 47)
			{
				x -= 10;
				move_pic.Location = new Point(x, 132);
				await Task.Delay(10);
			}

			Console.WriteLine(img);
			Left_Card.Image = img;
			move_pic.Visible = false;

		}
		#endregion

		private void Game_exit(object sender, FormClosingEventArgs e)
		{
            if (End_Game)
            {
				return;
            }
            Form_end = true;
			SqliteConnection.ClearAllPools();
			string folderPath = Path.Combine(Application.StartupPath, "Data");
			var dbPath = Path.Combine(folderPath, $"{Data_id + 1}.db");
			File.Delete(dbPath);
			Properties.Settings.Default.Warning_text = true;
		}
	}
}