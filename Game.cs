using haiandro.Card;
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
        public Game()
        {
            InitializeComponent();
            d.Shuffle();
            d.Card_kure();
            card_display();
            card_num1.Text = d.What_number();
            Start();
        }

        public async void Start()
        {
            progressBar1.Value = 0;
            await countdown();
        }

        private async Task countdown()
        {
            string value = progressBar1.Value.ToString();
            char[] test = value.ToCharArray();
            string text = "";
            while (progressBar1.Value < progressBar1.Maximum)
            {
                if (Answer == true)
                {
                    break;
                }
                await Task.Delay(100);
                value = progressBar1.Value.ToString();
                test = value.ToCharArray();
                if (progressBar1.Value <10)
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
                Console.WriteLine("勝負");
            }
            else
            {
                Answer_label.TextChanged -= battle;
                Console.WriteLine("時間切れ");
            }
            Timer_table.Visible = false;
        }

        private void card_display()
        {
            string image_name = d.Card_kure();
            Console.WriteLine(image_name);
            Image img = Properties.Resources.ResourceManager.GetObject(image_name) as Image;
            pictureBox1.Image = img;
            card_num1.Text = d.What_number();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                // デザイナーで設定した (Name) を取得
                string controlName = control.Text;

                Answer_label.Text = controlName;
            }
        }

        private async void battle(object? sender, EventArgs e)
        {
            //色々な処理
            Answer = true;
            Timer_table.Visible = false;

            //アニメーション用変数宣言
            int x = 450;
            vs_label.Location = new Point(x, 30);
            Console.WriteLine(vs_label.Location.X);
            vs_label.Visible = true;
            while (vs_label.Location.X > 150)
            {
                await Task.Delay(10);
                vs_label.Location = new Point(x, 30);
                x -= 15;
            }

            await Task.Delay(1500);

            while (vs_label.Location.X > -150)
            {
                await Task.Delay(10);
                vs_label.Location = new Point(x, 30);
                x -= 15;
            }


        }
    }
}
