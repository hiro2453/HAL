namespace haiandro
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void Exit_ToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Information_ToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var Game_window = new Game())
            {
                Game_window.ShowDialog();
            }
            this.Show();
        }

        private void Setting_button_Click(object sender, EventArgs e)
        {
            using (var Setting_window = new Setting())
            {
                Setting_window.ShowDialog();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var test = new teee();

            await test.Test();
        }
    }
}
