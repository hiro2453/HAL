using haiandro.Card;
using System.Diagnostics;

namespace haiandro
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
            Warning_label.Visible = false;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var Game_window = new Game(false, false))
            {
                Game_window.ShowDialog();
            }

            if (Properties.Settings.Default.Warning_text)
            {
                Warning_label.Visible = true;
            }
            else
            {
                Warning_label.Visible = false;
            }

            this.Show();
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var Setting_window = new Setting())
            {
                Setting_window.ShowDialog();
            }

            this.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void Info_Start(object sender, EventArgs e)
        {
            Info_Label.Text = "一人でプレイします";
        }

        private void Info_AI(object sender, EventArgs e)
        {
            Info_Label.Text = "AIと対戦します";
        }

        private void Info_Endless(object sender, EventArgs e)
        {
            Info_Label.Text = "はずれるまで無限に続きます";
        }

        private void Info_History(object sender, EventArgs e)
        {
            Info_Label.Text = "これまでプレイした履歴が見れます";
        }

        private void Info_Setting(object sender, EventArgs e)
        {
            Info_Label.Text = "ゲーム設定や試合数を変更できます";
        }

        private void Info_Tutorial(object sender, EventArgs e)
        {
            Info_Label.Text = "ハイアンドローの遊び方を知れます";
        }

        private void Link_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 実行ファイルと同じ階層にあるファイルのパスを取得
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "acknowledgments.rtf");
            if (File.Exists(filePath))
            {
                try
                {
                    // .NET Core / .NET 5以降では UseShellExecute = true の指定が必須です
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ファイルを開けませんでした。\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ライセンスファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Info_Link(object sender, EventArgs e)
        {
            Info_Label.Text = "ライセンス情報を見ることができます";
        }

        private void Button_History_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var History = new History())
            {
                History.ShowDialog();
            }

            this.Show();
        }

        private void Button_Endless_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var Game_window = new Game(true, false))
            {
                Game_window.ShowDialog();
            }

            if (Properties.Settings.Default.Warning_text)
            {
                Warning_label.Visible = true;
            }
            else
            {
                Warning_label.Visible = false;
            }

            this.Show();
        }

        private void Button_Tutorial_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var Tutorial = new Tutorial())
            {
                Tutorial.ShowDialog();
            }

            this.Show();
        }
    }
}
