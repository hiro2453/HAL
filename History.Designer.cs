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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
			Result = new DataGridViewTextBoxColumn();
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
			dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "-1";
			ID.DefaultCellStyle = dataGridViewCellStyle2;
			ID.HeaderText = "ID";
			ID.MinimumWidth = 50;
			ID.Name = "ID";
			ID.ReadOnly = true;
			ID.Resizable = DataGridViewTriState.True;
			ID.ToolTipText = "固有番号です。新しいデータほど値が大きくなります";
			// 
			// point
			// 
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = "-1";
			point.DefaultCellStyle = dataGridViewCellStyle3;
			point.HeaderText = "ポイント";
			point.MinimumWidth = 50;
			point.Name = "point";
			point.ReadOnly = true;
			point.ToolTipText = "予想が正解した回数です。";
			// 
			// mode
			// 
			mode.HeaderText = "モード";
			mode.MinimumWidth = 50;
			mode.Name = "mode";
			mode.ReadOnly = true;
			mode.ToolTipText = "その時選択したモードの情報です";
			// 
			// battle_set
			// 
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = "-1";
			battle_set.DefaultCellStyle = dataGridViewCellStyle4;
			battle_set.HeaderText = "試合回数";
			battle_set.MinimumWidth = 50;
			battle_set.Name = "battle_set";
			battle_set.ReadOnly = true;
			battle_set.ToolTipText = "試合を行った回数です";
			// 
			// date
			// 
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
			pictureBox3.Location = new Point(634, 64);
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
			dataGridView2.AllowUserToResizeColumns = false;
			dataGridView2.AllowUserToResizeRows = false;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Battle_count, You_Guess, Result });
			dataGridView2.Location = new Point(465, 95);
			dataGridView2.Margin = new Padding(0);
			dataGridView2.MultiSelect = false;
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.Size = new Size(300, 400);
			dataGridView2.TabIndex = 5;
			dataGridView2.TabStop = false;
			// 
			// Battle_count
			// 
			Battle_count.HeaderText = "戦目";
			Battle_count.Name = "Battle_count";
			Battle_count.ReadOnly = true;
			// 
			// You_Guess
			// 
			You_Guess.HeaderText = "予想";
			You_Guess.Name = "You_Guess";
			You_Guess.ReadOnly = true;
			// 
			// Result
			// 
			Result.HeaderText = "結果";
			Result.Name = "Result";
			Result.ReadOnly = true;
			// 
			// History
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			BackColor = SystemColors.Control;
			ClientSize = new Size(777, 504);
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
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn point;
		private DataGridViewTextBoxColumn mode;
		private DataGridViewTextBoxColumn battle_set;
		private DataGridViewTextBoxColumn date;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private DataGridView dataGridView2;
		private DataGridViewTextBoxColumn Battle_count;
		private DataGridViewTextBoxColumn You_Guess;
		private DataGridViewTextBoxColumn Result;
	}
}