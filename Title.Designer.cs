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
            label1 = new Label();
            Start_button = new Button();
            Setting_button = new Button();
            menuStrip1 = new MenuStrip();
            Game_ToolStrip = new ToolStripMenuItem();
            GameStart_ToolStrip = new ToolStripMenuItem();
            Exit_ToolStrip = new ToolStripMenuItem();
            Help_ToolStrip = new ToolStripMenuItem();
            Information_ToolStrip = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.Location = new Point(109, 107);
            label1.Name = "label1";
            label1.Size = new Size(209, 42);
            label1.TabIndex = 0;
            label1.Text = "タイトルロゴ";
            // 
            // Start_button
            // 
            Start_button.AutoSize = true;
            Start_button.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Start_button.Location = new Point(161, 299);
            Start_button.Name = "Start_button";
            Start_button.Size = new Size(102, 28);
            Start_button.TabIndex = 1;
            Start_button.Text = "ゲームスタート";
            Start_button.UseVisualStyleBackColor = true;
            Start_button.Click += Start_button_Click;
            // 
            // Setting_button
            // 
            Setting_button.AutoSize = true;
            Setting_button.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Setting_button.Location = new Point(161, 360);
            Setting_button.Name = "Setting_button";
            Setting_button.Size = new Size(102, 28);
            Setting_button.TabIndex = 2;
            Setting_button.Text = "設定";
            Setting_button.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Game_ToolStrip, Help_ToolStrip, Information_ToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 26);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Game_ToolStrip
            // 
            Game_ToolStrip.DropDownItems.AddRange(new ToolStripItem[] { GameStart_ToolStrip, Exit_ToolStrip });
            Game_ToolStrip.Name = "Game_ToolStrip";
            Game_ToolStrip.Size = new Size(56, 22);
            Game_ToolStrip.Text = "ゲーム";
            // 
            // GameStart_ToolStrip
            // 
            GameStart_ToolStrip.Name = "GameStart_ToolStrip";
            GameStart_ToolStrip.Size = new Size(160, 22);
            GameStart_ToolStrip.Text = "ゲームスタート";
            // 
            // Exit_ToolStrip
            // 
            Exit_ToolStrip.Name = "Exit_ToolStrip";
            Exit_ToolStrip.Size = new Size(160, 22);
            Exit_ToolStrip.Text = "終了";
            Exit_ToolStrip.Click += Exit_ToolStrip_Click;
            // 
            // Help_ToolStrip
            // 
            Help_ToolStrip.Name = "Help_ToolStrip";
            Help_ToolStrip.Size = new Size(56, 22);
            Help_ToolStrip.Text = "ヘルプ";
            // 
            // Information_ToolStrip
            // 
            Information_ToolStrip.Name = "Information_ToolStrip";
            Information_ToolStrip.Size = new Size(44, 22);
            Information_ToolStrip.Text = "情報";
            Information_ToolStrip.Click += Information_ToolStrip_Click;
            // 
            // Title
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(Setting_button);
            Controls.Add(Start_button);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Title";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "タイトル画面";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Start_button;
        private Button Setting_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Game_ToolStrip;
        private ToolStripMenuItem GameStart_ToolStrip;
        private ToolStripMenuItem Exit_ToolStrip;
        private ToolStripMenuItem Help_ToolStrip;
        private ToolStripMenuItem Information_ToolStrip;
    }
}
