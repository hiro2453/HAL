namespace haiandro
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            High_button = new Button();
            Low_button = new Button();
            Left_Card = new PictureBox();
            Answer_label = new Label();
            card_num1 = new Label();
            card_num2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Right_Card = new PictureBox();
            Action_table = new TableLayoutPanel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            Time = new TableLayoutPanel();
            label2 = new Label();
            info_label = new Label();
            Timer_table = new TableLayoutPanel();
            label3 = new Label();
            Result_img = new PictureBox();
            Result_Table = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            battle_kaime = new Label();
            Battle_AllCount_label = new Label();
            battle_Slash = new Label();
            battle_Count_label = new Label();
            move_pic = new PictureBox();
            Point_label = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Left_Card).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Right_Card).BeginInit();
            Action_table.SuspendLayout();
            Time.SuspendLayout();
            Timer_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Result_img).BeginInit();
            Result_Table.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)move_pic).BeginInit();
            SuspendLayout();
            // 
            // High_button
            // 
            High_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            High_button.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            High_button.Location = new Point(32, 3);
            High_button.Name = "High_button";
            High_button.Size = new Size(75, 34);
            High_button.TabIndex = 0;
            High_button.TabStop = false;
            High_button.Text = "High";
            High_button.UseVisualStyleBackColor = true;
            High_button.Click += button_Click;
            // 
            // Low_button
            // 
            Low_button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Low_button.AutoSize = true;
            Low_button.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Low_button.Location = new Point(173, 3);
            Low_button.Name = "Low_button";
            Low_button.Size = new Size(75, 34);
            Low_button.TabIndex = 1;
            Low_button.TabStop = false;
            Low_button.Text = "Low";
            Low_button.UseVisualStyleBackColor = true;
            Low_button.Click += button_Click;
            // 
            // Left_Card
            // 
            Left_Card.Image = (Image)resources.GetObject("Left_Card.Image");
            Left_Card.Location = new Point(15, 45);
            Left_Card.Margin = new Padding(15, 3, 15, 3);
            Left_Card.Name = "Left_Card";
            Left_Card.Size = new Size(150, 220);
            Left_Card.SizeMode = PictureBoxSizeMode.AutoSize;
            Left_Card.TabIndex = 2;
            Left_Card.TabStop = false;
            // 
            // Answer_label
            // 
            Answer_label.Font = new Font("FOT-ニューロダン Pro DB", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Answer_label.Location = new Point(72, 375);
            Answer_label.Name = "Answer_label";
            Answer_label.Size = new Size(281, 50);
            Answer_label.TabIndex = 4;
            Answer_label.Text = "どっち？";
            Answer_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card_num1
            // 
            card_num1.AutoSize = true;
            card_num1.Dock = DockStyle.Fill;
            card_num1.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            card_num1.Location = new Point(3, 0);
            card_num1.Name = "card_num1";
            card_num1.Size = new Size(174, 42);
            card_num1.TabIndex = 5;
            card_num1.Text = "?";
            card_num1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // card_num2
            // 
            card_num2.AutoSize = true;
            card_num2.Dock = DockStyle.Fill;
            card_num2.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            card_num2.Location = new Point(183, 0);
            card_num2.Name = "card_num2";
            card_num2.Size = new Size(174, 42);
            card_num2.TabIndex = 7;
            card_num2.Text = "?";
            card_num2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(card_num1, 0, 0);
            tableLayoutPanel1.Controls.Add(card_num2, 1, 0);
            tableLayoutPanel1.Controls.Add(Left_Card, 0, 1);
            tableLayoutPanel1.Controls.Add(Right_Card, 1, 1);
            tableLayoutPanel1.Location = new Point(32, 87);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(360, 268);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Right_Card
            // 
            Right_Card.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Right_Card.Image = (Image)resources.GetObject("Right_Card.Image");
            Right_Card.Location = new Point(195, 45);
            Right_Card.Margin = new Padding(15, 3, 15, 3);
            Right_Card.Name = "Right_Card";
            Right_Card.Size = new Size(150, 220);
            Right_Card.SizeMode = PictureBoxSizeMode.StretchImage;
            Right_Card.TabIndex = 3;
            Right_Card.TabStop = false;
            // 
            // Action_table
            // 
            Action_table.AutoSize = true;
            Action_table.ColumnCount = 2;
            Action_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Action_table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Action_table.Controls.Add(High_button, 0, 0);
            Action_table.Controls.Add(Low_button, 1, 0);
            Action_table.Location = new Point(72, 444);
            Action_table.Name = "Action_table";
            Action_table.RowCount = 1;
            Action_table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Action_table.Size = new Size(281, 40);
            Action_table.TabIndex = 10;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 46);
            progressBar1.Maximum = 50;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(360, 13);
            progressBar1.TabIndex = 11;
            progressBar1.Value = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point, 0, true);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(121, 0);
            label1.Margin = new Padding(3, 0, 0, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(61, 37);
            label1.TabIndex = 12;
            label1.Text = "5.0";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // Time
            // 
            Time.ColumnCount = 2;
            Time.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5555573F));
            Time.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4444427F));
            Time.Controls.Add(label2, 1, 0);
            Time.Controls.Add(label1, 0, 0);
            Time.Dock = DockStyle.Bottom;
            Time.Location = new Point(3, 3);
            Time.Name = "Time";
            Time.RowCount = 1;
            Time.RowStyles.Add(new RowStyle());
            Time.Size = new Size(360, 37);
            Time.TabIndex = 13;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("游ゴシック", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(185, 11);
            label2.Name = "label2";
            label2.Size = new Size(172, 26);
            label2.TabIndex = 13;
            label2.Text = "秒";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // info_label
            // 
            info_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            info_label.AutoSize = true;
            info_label.Font = new Font("HGP創英角ｺﾞｼｯｸUB", 12F, FontStyle.Regular, GraphicsUnit.Millimeter, 128);
            info_label.Location = new Point(398, 25);
            info_label.Name = "info_label";
            info_label.Size = new Size(125, 46);
            info_label.TabIndex = 14;
            info_label.Text = "勝負!";
            info_label.Visible = false;
            // 
            // Timer_table
            // 
            Timer_table.AutoSize = true;
            Timer_table.ColumnCount = 1;
            Timer_table.ColumnStyles.Add(new ColumnStyle());
            Timer_table.Controls.Add(Time, 0, 0);
            Timer_table.Controls.Add(progressBar1, 0, 1);
            Timer_table.Location = new Point(32, 22);
            Timer_table.Name = "Timer_table";
            Timer_table.RowCount = 2;
            Timer_table.RowStyles.Add(new RowStyle());
            Timer_table.RowStyles.Add(new RowStyle());
            Timer_table.Size = new Size(366, 62);
            Timer_table.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Meiryo UI", 8F, FontStyle.Bold, GraphicsUnit.Millimeter);
            label3.Location = new Point(195, -50);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(43, 40);
            label3.TabIndex = 16;
            label3.Text = ">";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // Result_img
            // 
            Result_img.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Result_img.Location = new Point(120, 3);
            Result_img.Margin = new Padding(120, 3, 120, 3);
            Result_img.Name = "Result_img";
            Result_img.Size = new Size(120, 71);
            Result_img.SizeMode = PictureBoxSizeMode.StretchImage;
            Result_img.TabIndex = 17;
            Result_img.TabStop = false;
            Result_img.Visible = false;
            // 
            // Result_Table
            // 
            Result_Table.ColumnCount = 1;
            Result_Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Result_Table.Controls.Add(Result_img, 0, 0);
            Result_Table.Location = new Point(32, 361);
            Result_Table.Name = "Result_Table";
            Result_Table.RowCount = 1;
            Result_Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Result_Table.Size = new Size(360, 77);
            Result_Table.TabIndex = 18;
            Result_Table.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(battle_kaime, 3, 0);
            tableLayoutPanel2.Controls.Add(Battle_AllCount_label, 2, 0);
            tableLayoutPanel2.Controls.Add(battle_Slash, 1, 0);
            tableLayoutPanel2.Controls.Add(battle_Count_label, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 498);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(156, 21);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // battle_kaime
            // 
            battle_kaime.AutoSize = true;
            battle_kaime.Dock = DockStyle.Left;
            battle_kaime.Font = new Font("游ゴシック", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            battle_kaime.Location = new Point(95, 0);
            battle_kaime.Name = "battle_kaime";
            battle_kaime.Size = new Size(58, 21);
            battle_kaime.TabIndex = 3;
            battle_kaime.Text = "かいめ";
            battle_kaime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Battle_AllCount_label
            // 
            Battle_AllCount_label.AutoSize = true;
            Battle_AllCount_label.Dock = DockStyle.Left;
            Battle_AllCount_label.Font = new Font("游ゴシック", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Battle_AllCount_label.Location = new Point(52, 0);
            Battle_AllCount_label.Name = "Battle_AllCount_label";
            Battle_AllCount_label.Size = new Size(37, 21);
            Battle_AllCount_label.TabIndex = 2;
            Battle_AllCount_label.Text = "530";
            Battle_AllCount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // battle_Slash
            // 
            battle_Slash.AutoSize = true;
            battle_Slash.Dock = DockStyle.Fill;
            battle_Slash.Font = new Font("游ゴシック", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            battle_Slash.Location = new Point(28, 0);
            battle_Slash.Name = "battle_Slash";
            battle_Slash.Size = new Size(18, 21);
            battle_Slash.TabIndex = 1;
            battle_Slash.Text = "/";
            battle_Slash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // battle_Count_label
            // 
            battle_Count_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            battle_Count_label.AutoSize = true;
            battle_Count_label.Font = new Font("游ゴシック", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            battle_Count_label.Location = new Point(3, 0);
            battle_Count_label.Name = "battle_Count_label";
            battle_Count_label.Size = new Size(19, 21);
            battle_Count_label.TabIndex = 0;
            battle_Count_label.Text = "1";
            battle_Count_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // move_pic
            // 
            move_pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            move_pic.Image = (Image)resources.GetObject("move_pic.Image");
            move_pic.Location = new Point(410, 135);
            move_pic.Margin = new Padding(15, 3, 15, 3);
            move_pic.Name = "move_pic";
            move_pic.Size = new Size(150, 220);
            move_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            move_pic.TabIndex = 20;
            move_pic.TabStop = false;
            move_pic.Visible = false;
            // 
            // Point_label
            // 
            Point_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Point_label.FlatStyle = FlatStyle.System;
            Point_label.Font = new Font("游ゴシック", 16F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Point_label.Location = new Point(295, 495);
            Point_label.Name = "Point_label";
            Point_label.Size = new Size(100, 23);
            Point_label.TabIndex = 21;
            Point_label.Text = "0";
            Point_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("游ゴシック", 16F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label5.Location = new Point(398, 494);
            label5.Name = "label5";
            label5.Size = new Size(34, 29);
            label5.TabIndex = 22;
            label5.Text = "pt";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 531);
            Controls.Add(label5);
            Controls.Add(Point_label);
            Controls.Add(move_pic);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label3);
            Controls.Add(info_label);
            Controls.Add(Timer_table);
            Controls.Add(Action_table);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Answer_label);
            Controls.Add(Result_Table);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ゲーム画面";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)Left_Card).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Right_Card).EndInit();
            Action_table.ResumeLayout(false);
            Action_table.PerformLayout();
            Time.ResumeLayout(false);
            Timer_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Result_img).EndInit();
            Result_Table.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)move_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button High_button;
        private Button Low_button;
        private PictureBox Left_Card;
        private Label Answer_label;
        private Label card_num1;
        private Label card_num2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel Action_table;
        private ProgressBar progressBar1;
        private Label label1;
        private TableLayoutPanel Time;
        private Label label2;
        private Label info_label;
        private TableLayoutPanel Timer_table;
        private PictureBox Right_Card;
        private Label label3;
        private TableLayoutPanel Result_Table;
        private PictureBox Result_img;
        private TableLayoutPanel tableLayoutPanel2;
        private Label battle_kaime;
        private Label Battle_AllCount_label;
        private Label battle_Slash;
        private Label battle_Count_label;
        private PictureBox move_pic;
        private Label Point_label;
        private Label label5;
    }
}