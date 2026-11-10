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
            if (Radio_Deck.Checked)
            {
                All_battle_Count.Text = (numericUpDown1.Value * 51).ToString();
            }
            if (Radio_CardCount.Checked)
            {
                All_battle_Count.Text = (numericUpDown1.Value - 2).ToString();
            }
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
            if (A_check.Checked)
            {
                A_pic.Image = Properties.Resources.Rei2;
            }
            else
            {
                A_pic.Image = Properties.Resources.rei1;
            }
        }

        private void Game_Radio_change(object sender, EventArgs e)
        {
            if (Radio_CardCount.Checked)
            {
                Properties.Settings.Default.Card_ALLCount = true;
                Properties.Settings.Default.Deck_option = false;
                Game_battle_info.Text = "※12-502以内で設定可能";
                Radio_Deck.Checked = false;
                numericUpDown1.Maximum = 502;
                numericUpDown1.Increment = 5;
                numericUpDown1.Minimum = 10;
                numericUpDown1.Value = 22;
            }

            if (Radio_Deck.Checked)
            {
                Properties.Settings.Default.Card_ALLCount = false;
                Properties.Settings.Default.Deck_option = true;
                Game_battle_info.Text = "※1-10以内で設定可能";
                Radio_CardCount.Checked = false;
                numericUpDown1.Maximum = 10;
                numericUpDown1.Increment = 1;
                numericUpDown1.Minimum = 1;
                numericUpDown1.Value = 1;
            }
        }
        private void ValueChanged(object sender, EventArgs e)
        {
            if (Radio_Deck.Checked)
            {
                All_battle_Count.Text = (numericUpDown1.Value * 51).ToString();
            }
            if (Radio_CardCount.Checked)
            {
                All_battle_Count.Text = (numericUpDown1.Value - 2).ToString();
            }
        }

        private void Deck_info(object sender, EventArgs e)
        {
            StatusLabel.Text = "デック基準で試合数を決定します";
        }

        private void CardCount_info(object sender, EventArgs e)
        {
            StatusLabel.Text = "何枚カードを使うかで試合数を決定します";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MessageBox.Show("保存しました", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Exit_Check(object sender, FormClosingEventArgs e)
        {
            DialogResult check = MessageBox.Show("変更が保存されていない可能性があります！\n本当に設定画面を閉じますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (check == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }

            if (check == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
