using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haiandro
{
    public partial class Game : Form
    {
        Deck d = new Deck();
        int battle_Count = 0;
        int now_battle = 0;
        bool Answer = false;
        bool High = false;
        bool Low = false;

        public Game()
        {
            InitializeComponent();
            Result_Table.Visible = true;

            if (Properties.Settings.Default.Deck_option)
            {
                battle_Count = Properties.Settings.Default.set * 51;
                Battle_AllCount_label.Text = battle_Count.ToString();
            }
            if (Properties.Settings.Default.Card_ALLCount)
            {
                battle_Count = Properties.Settings.Default.set;
                Battle_AllCount_label.Text = battle_Count.ToString();
            }

            d.Shuffle();
            d.Card_kure();
            card_display();
            card_num1.Text = d.What_number();
            Battle_AllCount_label.Text = "2"; //Properties.Settings.Default.set.ToString();
            Start();
        }
        
        #region 勝負開始
        public async void Start()
        {
            now_battle++;
            High = false;
            Low = false;
            Answer = false;
            countdown();
            battle_Count_label.Text = now_battle.ToString();
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

            await Task.Delay(100);
            label1.Text = "0.0";
            progressBar1.Visible = false;
            Answer_label.Text = "時間切れ";
            Action_table.Visible = false;
            Console.WriteLine("時間切れ");
            
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
                string controlName = control.Text;
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
            Console.WriteLine($"[デバック]左は{card_num1.Text}です。右は{card_num2.Text}です");

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

            await Task.Delay(1000);

            Console.WriteLine($"[デバック]試合終了：{int.Parse(Battle_AllCount_label.Text) == int.Parse(battle_Count_label.Text)}");
            if (int.Parse(Battle_AllCount_label.Text) ==int.Parse(battle_Count_label.Text))
            {
                Answer_label.Text = "試合終了！";
                await Task.Delay (1000);

                //データベース処理
                var connectionString = "Data Source=test.db";
                using var connection = new SqliteConnection(connectionString);
                connection.Open();

                var sql = "INSERT INTO Battle_History (id, point, Date) VALUES (@id, @point, @Date)";
                using var command = new SqliteCommand(sql, connection);

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                command.Parameters.AddWithValue("@id", Properties.Settings.Default.ID);
                command.Parameters.AddWithValue("@point", int.Parse(Point_label.Text));
                command.Parameters.AddWithValue("@Date", today);

                command.ExecuteNonQuery();

                MessageBox.Show($"設定試合数まで達しました。\n\nID:{Properties.Settings.Default.ID}\nポイント：{Point_label.Text}\n保存日時：{today}\n\nOKを押すとタイトル画面に戻ります。","結果発表",MessageBoxButtons.OK,MessageBoxIcon.None);
                this.Close();
                return;
            }

            await Move_card(Right_Card.Image);
            Start();
        }
        #endregion

        #region 「あたり」「はずれ」「ドロー」を表示する処理
        private async Task Result_display(char Check)
        {
            Result_Table.Visible = true;
            Result_Table.BringToFront();
            switch (Check)
            {
                case 'w':
                    Result_img.Image = Properties.Resources.WIN;
                    Point_label.Text = (int.Parse(Point_label.Text) + 1).ToString();
                    break;
                case 'l':
                    Result_img.Image = Properties.Resources.LOSE;
                    break;
                case 'd':
                    Result_img.Image = Properties.Resources.DRAW;
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
            move_pic.Visible= false;

        }
        #endregion
    }
}
