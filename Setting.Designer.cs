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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)A_pic).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(A_pic);
            groupBox1.Controls.Add(A_check);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 202);
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
            statusStrip1.Location = new Point(0, 347);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(549, 22);
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
            // Setting
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(549, 369);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Font = new Font("ＭＳ ゴシック", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Setting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "設定画面";
            MouseHover += info_default;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)A_pic).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox A_pic;
        private CheckBox A_check;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
    }
}