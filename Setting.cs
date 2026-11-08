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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            A_check.Checked = Properties.Settings.Default.A_Strong ? true : false;
        }

        private void info_A(object sender, EventArgs e)
        {
            StatusLabel.Text = "Aを最強にするか最弱にするかの設定です";
        }

        private void info_default(object sender, EventArgs e)
        {
            StatusLabel.Text = "ここに説明が表示されます";
        }

        private void A_change(object sender, EventArgs e)
        {
            if (A_check.Checked == true)
            {
                A_pic.Image = Properties.Resources.Rei2;
            }
            else
            {
                A_pic.Image = Properties.Resources.rei1;
            }
        }
    }
}
