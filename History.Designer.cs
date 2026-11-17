namespace haiandro
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            point = new DataGridViewTextBoxColumn();
            mode = new DataGridViewTextBoxColumn();
            battle_set = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            dataGridView2 = new DataGridView();
            Battle_count = new DataGridViewTextBoxColumn();
            You_Guess = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Result = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.play_history;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 192, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, point, mode, battle_set, date });
            dataGridView1.Location = new Point(10, 95);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(450, 400);
            dataGridView1.TabIndex = 2;
            dataGridView1.TabStop = false;
            dataGridView1.CellClick += Cell_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "-1";
            ID.DefaultCellStyle = dataGridViewCellStyle9;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 50;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.ToolTipText = "固有番号です。新しいデータほど値が大きくなります";
            // 
            // point
            // 
            point.DataPropertyName = "point";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "-1";
            point.DefaultCellStyle = dataGridViewCellStyle10;
            point.HeaderText = "ポイント";
            point.MinimumWidth = 50;
            point.Name = "point";
            point.ReadOnly = true;
            point.ToolTipText = "予想が正解した回数です。";
            // 
            // mode
            // 
            mode.DataPropertyName = "mode";
            mode.HeaderText = "モード";
            mode.MinimumWidth = 50;
            mode.Name = "mode";
            mode.ReadOnly = true;
            mode.ToolTipText = "その時選択したモードの情報です";
            // 
            // battle_set
            // 
            battle_set.DataPropertyName = "battle_set";
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = "-1";
            battle_set.DefaultCellStyle = dataGridViewCellStyle11;
            battle_set.HeaderText = "試合回数";
            battle_set.MinimumWidth = 50;
            battle_set.Name = "battle_set";
            battle_set.ReadOnly = true;
            battle_set.ToolTipText = "試合を行った回数です";
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "日付";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.battle_history;
            pictureBox2.Location = new Point(329, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(131, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.battle_more;
            pictureBox3.Location = new Point(796, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(131, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Battle_count, You_Guess, Column1, Column2, Result, Column3 });
            dataGridView2.Location = new Point(465, 95);
            dataGridView2.Margin = new Padding(0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(462, 400);
            dataGridView2.TabIndex = 5;
            dataGridView2.TabStop = false;
            // 
            // Battle_count
            // 
            Battle_count.DataPropertyName = "bc";
            Battle_count.HeaderText = "戦目";
            Battle_count.Name = "Battle_count";
            Battle_count.ReadOnly = true;
            Battle_count.ToolTipText = "何戦目かの列です";
            // 
            // You_Guess
            // 
            You_Guess.DataPropertyName = "Guess";
            You_Guess.HeaderText = "予想";
            You_Guess.Name = "You_Guess";
            You_Guess.ReadOnly = true;
            You_Guess.ToolTipText = "あなたがどっちに予想したかの列です";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Left_Card";
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = "-1";
            Column1.DefaultCellStyle = dataGridViewCellStyle12;
            Column1.HeaderText = "左カード";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.ToolTipText = "左のカードの数字です";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Right_Card";
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = "-1";
            Column2.DefaultCellStyle = dataGridViewCellStyle13;
            Column2.HeaderText = "右カード";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.ToolTipText = "右のカードの数字です";
            // 
            // Result
            // 
            Result.DataPropertyName = "Result";
            dataGridViewCellStyle14.NullValue = "？";
            Result.DefaultCellStyle = dataGridViewCellStyle14;
            Result.HeaderText = "結果";
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.ToolTipText = "勝敗の列です";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "select_time";
            Column3.HeaderText = "選択時間";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.ToolTipText = "選択するのにかかった時間です";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(934, 504);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Font = new Font("Meiryo UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "プレイ履歴";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
		private DataGridView dataGridView1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn point;
        private DataGridViewTextBoxColumn mode;
        private DataGridViewTextBoxColumn battle_set;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Battle_count;
        private DataGridViewTextBoxColumn You_Guess;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Result;
        private DataGridViewTextBoxColumn Column3;
    }
}