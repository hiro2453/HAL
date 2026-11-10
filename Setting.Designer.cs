namespace haiandro
{
    partial class Setting
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
            groupBox1 = new GroupBox();
            A_pic = new PictureBox();
            A_check = new CheckBox();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            All_battle_Count = new Label();
            label1 = new Label();
            Game_battle_info = new Label();
            numericUpDown1 = new NumericUpDown();
            Radio_CardCount = new RadioButton();
            Radio_Deck = new RadioButton();
            Save_Button = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)A_pic).BeginInit();
            statusStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(A_pic);
            groupBox1.Controls.Add(A_check);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "カードの強さ";
            // 
            // A_pic
            // 
            A_pic.Image = Properties.Resources.rei1;
            A_pic.Location = new Point(6, 46);
            A_pic.Name = "A_pic";
            A_pic.Size = new Size(276, 149);
            A_pic.SizeMode = PictureBoxSizeMode.Zoom;
            A_pic.TabIndex = 2;
            A_pic.TabStop = false;
            A_pic.WaitOnLoad = true;
            // 
            // A_check
            // 
            A_check.AutoSize = true;
            A_check.Location = new Point(6, 24);
            A_check.Name = "A_check";
            A_check.Size = new Size(102, 16);
            A_check.TabIndex = 1;
            A_check.Text = "Aを最強にする";
            A_check.UseVisualStyleBackColor = true;
            A_check.CheckedChanged += A_change;
            A_check.MouseEnter += info_A;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
            statusStrip1.Location = new Point(0, 384);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(314, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("ＭＳ Ｐゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(140, 17);
            StatusLabel.Text = "ここに説明が表示されます";
            StatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(All_battle_Count);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Game_battle_info);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(Radio_CardCount);
            groupBox2.Controls.Add(Radio_Deck);
            groupBox2.Location = new Point(12, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ゲーム設定";
            // 
            // All_battle_Count
            // 
            All_battle_Count.Anchor = AnchorStyles.Right;
            All_battle_Count.FlatStyle = FlatStyle.System;
            All_battle_Count.Font = new Font("ＭＳ Ｐゴシック", 12F, FontStyle.Regular, GraphicsUnit.Millimeter);
            All_battle_Count.Location = new Point(192, 43);
            All_battle_Count.Name = "All_battle_Count";
            All_battle_Count.RightToLeft = RightToLeft.Yes;
            All_battle_Count.Size = new Size(82, 46);
            All_battle_Count.TabIndex = 6;
            All_battle_Count.Text = "0";
            All_battle_Count.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("ＭＳ Ｐゴシック", 12F);
            label1.Location = new Point(184, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 16);
            label1.TabIndex = 5;
            label1.Text = "行う試合数";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Game_battle_info
            // 
            Game_battle_info.AutoSize = true;
            Game_battle_info.Location = new Point(6, 65);
            Game_battle_info.Name = "Game_battle_info";
            Game_battle_info.Size = new Size(125, 12);
            Game_battle_info.TabIndex = 4;
            Game_battle_info.Text = "※1-10以内で設定可能";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(34, 43);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 19);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += ValueChanged;
            // 
            // Radio_CardCount
            // 
            Radio_CardCount.AutoSize = true;
            Radio_CardCount.Location = new Point(83, 21);
            Radio_CardCount.Name = "Radio_CardCount";
            Radio_CardCount.Size = new Size(59, 16);
            Radio_CardCount.TabIndex = 1;
            Radio_CardCount.Text = "枚数制";
            Radio_CardCount.UseVisualStyleBackColor = true;
            Radio_CardCount.CheckedChanged += Game_Radio_change;
            Radio_CardCount.MouseEnter += CardCount_info;
            // 
            // Radio_Deck
            // 
            Radio_Deck.AutoSize = true;
            Radio_Deck.Checked = true;
            Radio_Deck.Location = new Point(6, 21);
            Radio_Deck.Name = "Radio_Deck";
            Radio_Deck.Size = new Size(71, 16);
            Radio_Deck.TabIndex = 0;
            Radio_Deck.TabStop = true;
            Radio_Deck.Text = "デック制";
            Radio_Deck.UseVisualStyleBackColor = true;
            Radio_Deck.MouseEnter += Deck_info;
            // 
            // Save_Button
            // 
            Save_Button.AutoSize = true;
            Save_Button.Font = new Font("ＭＳ ゴシック", 12F);
            Save_Button.Location = new Point(115, 335);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(75, 30);
            Save_Button.TabIndex = 3;
            Save_Button.Text = "保存";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Click;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(314, 406);
            Controls.Add(Save_Button);
            Controls.Add(groupBox2);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Font = new Font("ＭＳ ゴシック", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "設定画面";
            FormClosing += Exit_Check;
            MouseHover += info_default;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)A_pic).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox A_pic;
        private CheckBox A_check;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private GroupBox groupBox2;
        private RadioButton Radio_CardCount;
        private RadioButton Radio_Deck;
        private Label Game_battle_info;
        private NumericUpDown numericUpDown1;
        private Label All_battle_Count;
        private Label label1;
        private Button Save_Button;
    }
}