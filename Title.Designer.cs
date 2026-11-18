namespace haiandro
{
    partial class Title
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tableLayoutPanel1 = new TableLayoutPanel();
			Pic_History = new PictureBox();
			Pic_endless = new PictureBox();
			Pic_AI = new PictureBox();
			Pic_start = new PictureBox();
			Pic_LOGO = new PictureBox();
			Button_Tutorial = new Button();
			tableLayoutPanel2 = new TableLayoutPanel();
			label1 = new Label();
			Link_Label = new LinkLabel();
			Button_Setting = new Button();
			Warning_label = new Label();
			statusStrip1 = new StatusStrip();
			Info_Label = new ToolStripStatusLabel();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Pic_History).BeginInit();
			((System.ComponentModel.ISupportInitialize)Pic_endless).BeginInit();
			((System.ComponentModel.ISupportInitialize)Pic_AI).BeginInit();
			((System.ComponentModel.ISupportInitialize)Pic_start).BeginInit();
			((System.ComponentModel.ISupportInitialize)Pic_LOGO).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(Pic_History, 0, 3);
			tableLayoutPanel1.Controls.Add(Pic_endless, 0, 2);
			tableLayoutPanel1.Controls.Add(Pic_AI, 0, 1);
			tableLayoutPanel1.Controls.Add(Pic_start, 0, 0);
			tableLayoutPanel1.Location = new Point(242, 12);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(180, 296);
			tableLayoutPanel1.TabIndex = 5;
			// 
			// Pic_History
			// 
			Pic_History.Anchor = AnchorStyles.None;
			Pic_History.Cursor = Cursors.Hand;
			Pic_History.Image = Properties.Resources.History;
			Pic_History.Location = new Point(57, 244);
			Pic_History.Name = "Pic_History";
			Pic_History.Size = new Size(65, 30);
			Pic_History.SizeMode = PictureBoxSizeMode.AutoSize;
			Pic_History.TabIndex = 11;
			Pic_History.TabStop = false;
			Pic_History.Click += Button_click;
			Pic_History.MouseEnter += Button_Hover;
			Pic_History.MouseLeave += Button_Leave;
			// 
			// Pic_endless
			// 
			Pic_endless.Anchor = AnchorStyles.None;
			Pic_endless.Cursor = Cursors.Hand;
			Pic_endless.Image = Properties.Resources.Endless;
			Pic_endless.Location = new Point(15, 170);
			Pic_endless.Name = "Pic_endless";
			Pic_endless.Size = new Size(150, 30);
			Pic_endless.SizeMode = PictureBoxSizeMode.AutoSize;
			Pic_endless.TabIndex = 10;
			Pic_endless.TabStop = false;
			Pic_endless.Click += Button_click;
			Pic_endless.MouseEnter += Button_Hover;
			Pic_endless.MouseLeave += Button_Leave;
			// 
			// Pic_AI
			// 
			Pic_AI.Anchor = AnchorStyles.None;
			Pic_AI.Cursor = Cursors.Hand;
			Pic_AI.Image = Properties.Resources.AI;
			Pic_AI.Location = new Point(15, 94);
			Pic_AI.Name = "Pic_AI";
			Pic_AI.Size = new Size(150, 34);
			Pic_AI.SizeMode = PictureBoxSizeMode.AutoSize;
			Pic_AI.TabIndex = 9;
			Pic_AI.TabStop = false;
			Pic_AI.Click += Button_click;
			Pic_AI.MouseEnter += Button_Hover;
			Pic_AI.MouseLeave += Button_Leave;
			// 
			// Pic_start
			// 
			Pic_start.Anchor = AnchorStyles.None;
			Pic_start.Cursor = Cursors.Hand;
			Pic_start.Image = Properties.Resources.Solo;
			Pic_start.Location = new Point(15, 22);
			Pic_start.Name = "Pic_start";
			Pic_start.Size = new Size(150, 29);
			Pic_start.SizeMode = PictureBoxSizeMode.AutoSize;
			Pic_start.TabIndex = 8;
			Pic_start.TabStop = false;
			Pic_start.Click += Button_click;
			Pic_start.MouseEnter += Button_Hover;
			Pic_start.MouseLeave += Button_Leave;
			// 
			// Pic_LOGO
			// 
			tableLayoutPanel2.SetColumnSpan(Pic_LOGO, 2);
			Pic_LOGO.Dock = DockStyle.Fill;
			Pic_LOGO.Image = Properties.Resources.LOGO;
			Pic_LOGO.Location = new Point(3, 3);
			Pic_LOGO.Name = "Pic_LOGO";
			Pic_LOGO.Size = new Size(216, 139);
			Pic_LOGO.SizeMode = PictureBoxSizeMode.AutoSize;
			Pic_LOGO.TabIndex = 6;
			Pic_LOGO.TabStop = false;
			// 
			// Button_Tutorial
			// 
			Button_Tutorial.Anchor = AnchorStyles.None;
			Button_Tutorial.AutoSize = true;
			Button_Tutorial.Location = new Point(25, 243);
			Button_Tutorial.Name = "Button_Tutorial";
			Button_Tutorial.Size = new Size(60, 29);
			Button_Tutorial.TabIndex = 8;
			Button_Tutorial.Text = "遊び方";
			Button_Tutorial.UseVisualStyleBackColor = true;
			Button_Tutorial.Click += Button_Tutorial_Click;
			Button_Tutorial.MouseEnter += Info_Tutorial;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(Pic_LOGO, 0, 0);
			tableLayoutPanel2.Controls.Add(label1, 1, 1);
			tableLayoutPanel2.Controls.Add(Link_Label, 0, 1);
			tableLayoutPanel2.Controls.Add(Button_Tutorial, 0, 3);
			tableLayoutPanel2.Controls.Add(Button_Setting, 1, 3);
			tableLayoutPanel2.Controls.Add(Warning_label, 0, 2);
			tableLayoutPanel2.Location = new Point(12, 12);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 4;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
			tableLayoutPanel2.Size = new Size(222, 296);
			tableLayoutPanel2.TabIndex = 9;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Location = new Point(136, 155);
			label1.Name = "label1";
			label1.Size = new Size(60, 18);
			label1.TabIndex = 11;
			label1.Text = "Ver 1.0.0";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Link_Label
			// 
			Link_Label.Anchor = AnchorStyles.None;
			Link_Label.AutoSize = true;
			Link_Label.Location = new Point(39, 155);
			Link_Label.Name = "Link_Label";
			Link_Label.Size = new Size(32, 18);
			Link_Label.TabIndex = 10;
			Link_Label.TabStop = true;
			Link_Label.Text = "謝辞";
			Link_Label.TextAlign = ContentAlignment.MiddleCenter;
			Link_Label.LinkClicked += Link_Click;
			Link_Label.MouseEnter += Info_Link;
			// 
			// Button_Setting
			// 
			Button_Setting.Anchor = AnchorStyles.None;
			Button_Setting.AutoSize = true;
			Button_Setting.Location = new Point(136, 243);
			Button_Setting.Name = "Button_Setting";
			Button_Setting.Size = new Size(60, 29);
			Button_Setting.TabIndex = 9;
			Button_Setting.Text = "設定";
			Button_Setting.UseVisualStyleBackColor = true;
			Button_Setting.Click += Setting_button_Click;
			Button_Setting.MouseEnter += Info_Setting;
			// 
			// Warning_label
			// 
			Warning_label.Anchor = AnchorStyles.None;
			Warning_label.AutoSize = true;
			tableLayoutPanel2.SetColumnSpan(Warning_label, 2);
			Warning_label.Font = new Font("HGP明朝E", 10F, FontStyle.Regular, GraphicsUnit.Point, 128);
			Warning_label.ForeColor = Color.Red;
			Warning_label.Location = new Point(11, 187);
			Warning_label.Name = "Warning_label";
			Warning_label.Size = new Size(200, 28);
			Warning_label.TabIndex = 12;
			Warning_label.Text = "試合が中断したため\r\n進行していた記録を削除しました";
			Warning_label.TextAlign = ContentAlignment.MiddleCenter;
			Warning_label.Visible = false;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { Info_Label });
			statusStrip1.Location = new Point(0, 312);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(434, 23);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 10;
			statusStrip1.Text = "statusStrip1";
			// 
			// Info_Label
			// 
			Info_Label.Name = "Info_Label";
			Info_Label.Size = new Size(296, 18);
			Info_Label.Text = "ボタンにマウスを置くと、ここに説明が表示されます";
			// 
			// Title
			// 
			AutoScaleDimensions = new SizeF(7F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(434, 335);
			Controls.Add(statusStrip1);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Title";
			SizeGripStyle = SizeGripStyle.Hide;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "タイトル画面";
			TopMost = true;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Pic_History).EndInit();
			((System.ComponentModel.ISupportInitialize)Pic_endless).EndInit();
			((System.ComponentModel.ISupportInitialize)Pic_AI).EndInit();
			((System.ComponentModel.ISupportInitialize)Pic_start).EndInit();
			((System.ComponentModel.ISupportInitialize)Pic_LOGO).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Pic_LOGO;
        private Button Button_Tutorial;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Button_Setting;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Info_Label;
        private LinkLabel Link_Label;
        private Label label1;
        private Label Warning_label;
        private Label label2;
        private PictureBox Pic_start;
        private PictureBox Pic_endless;
        private PictureBox Pic_AI;
		private PictureBox Pic_History;
	}
}
