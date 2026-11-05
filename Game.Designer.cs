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
            button3 = new Button();
            card_num2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            Right_Card = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            Time = new TableLayoutPanel();
            label2 = new Label();
            info_label = new Label();
            Timer_table = new TableLayoutPanel();
            label3 = new Label();
            Result_img = new PictureBox();
            Result_Table = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Left_Card).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Right_Card).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            Time.SuspendLayout();
            Timer_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Result_img).BeginInit();
            Result_Table.SuspendLayout();
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
            Answer_label.TextChanged += battle;
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
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button3.Location = new Point(175, 490);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // card_num2
            // 
            card_num2.AutoSize = true;
            card_num2.Dock = DockStyle.Fill;
            card_num2.Font = new Font("游明朝 Demibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(High_button, 0, 0);
            tableLayoutPanel2.Controls.Add(Low_button, 1, 0);
            tableLayoutPanel2.Location = new Point(72, 444);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(281, 40);
            tableLayoutPanel2.TabIndex = 10;
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
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Cambria", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 37);
            label1.TabIndex = 12;
            label1.Text = "5.0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Time.ColumnCount = 2;
            Time.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Time.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
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
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("游明朝 Demibold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 8);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 13;
            label2.Text = "秒";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // info_label
            // 
            info_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            info_label.AutoSize = true;
            info_label.Font = new Font("HGP創英角ｺﾞｼｯｸUB", 12F, FontStyle.Regular, GraphicsUnit.Millimeter, 128);
            info_label.Location = new Point(150, 30);
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
            Result_img.Image = Properties.Resources.WIN;
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
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 531);
            Controls.Add(label3);
            Controls.Add(info_label);
            Controls.Add(Timer_table);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button3);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            Time.ResumeLayout(false);
            Time.PerformLayout();
            Timer_table.ResumeLayout(false);
            Timer_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Result_img).EndInit();
            Result_Table.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button High_button;
        private Button Low_button;
        private PictureBox Left_Card;
        private Label Answer_label;
        private Label card_num1;
        private Button button3;
        private Label card_num2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ProgressBar progressBar1;
        private Label label1;
        private TableLayoutPanel Time;
        private Label label2;
        private Label info_label;
        private TableLayoutPanel Timer_table;
        private PictureBox Right_Card;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel Result_Table;
        private PictureBox Result_img;
    }
}