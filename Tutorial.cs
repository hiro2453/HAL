using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace haiandro.Card
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Audio Files (.wav)|*.wav";

            string folderPath = Path.Combine(Application.StartupPath, "video");
            string dbPath = Path.Combine(folderPath, "test.mp4");
            Console.WriteLine(dbPath);
            axWindowsMediaPlayer1.URL = dbPath;
        }
    }
}
