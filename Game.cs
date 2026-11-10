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
        bool Answer = false;
        bool High = false;
        bool Low = false;

        public Game()
        {
            InitializeComponent();
            Result_Table.Visible = true;
            d.Shuffle();
            d.Card_kure();
            card_display();
            card_num1.Text = d.What_number();
            Battle_AllCount_label.Text = (51 * Properties.Settings.Default.set).ToString();
            Start();
        }

        public async void Start()
        {
            if (battle_Count_label.Text == Battle_AllCount_label.Text)
            {
                
            }
            High = false;
            Low = false;
            Answer = false;
            await countdown();
            battle_Count_label.Text = d.What_AllCard();
        }

        private async Task countdown()
        {
            Timer_table.Visible = true;
            progressBar1.Value = 0;
            label1.Text = "5.0";
            card_num2.Text = "？";
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
            else
            {
                await Task.Delay(100);
                label1.Text = "0.0";
                progressBar1.Visible = false;
                Answer_label.Text = "時間切れ";
                Action_table.Visible = false;
                Console.WriteLine("時間切れ");
            }
        }

        private void card_display()
        {
            string image_name = d.Card_kure();
            Image img = Properties.Resources.ResourceManager.GetObject(image_name) as Image;
            Left_Card.Image = img;
            card_num1.Text = d.What_number();
        }

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
                Console.WriteLine(High);
                Console.WriteLine(Low);
                Answer_label.Text = controlName;
            }
        }

        private async void battle()
        {
            //色々な処理
            Answer = true;
            Timer_table.Visible = false;

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
            await Move_card(Right_Card.Image);
            Start();

        }
        private async Task Result_display(char Check)
        {
            Result_Table.Visible = true;
            Result_Table.BringToFront();
            switch (Check)
            {
                case 'w':
                    Result_img.Image = Properties.Resources.WIN;
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

            while (Result_img.Size.Height < 65)
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

            Left_Card.Image = img;
            move_pic.Visible= false;

        }
        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
