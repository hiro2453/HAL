using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace haiandro
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3;");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
