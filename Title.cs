using haiandro.Card;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;

namespace haiandro
{
	public partial class Title : Form
	{

		public Title()
		{
			InitializeComponent();
			Warning_label.Visible = false;
		}

		private void Setting_button_Click(object sender, EventArgs e)
		{
			this.Hide();

			using (var Setting_window = new Setting())
			{
				Setting_window.ShowDialog();
			}

			this.Show();
		}

		private void Info_Setting(object sender, EventArgs e)
		{
			Info_Label.Text = "ゲーム設定や試合数を変更できます";
		}

		private void Info_Tutorial(object sender, EventArgs e)
		{
			Info_Label.Text = "ハイアンドローの遊び方を知れます";
		}

		private void Link_Click(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// 実行ファイルと同じ階層にあるファイルのパスを取得
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "acknowledgments.rtf");
			if (File.Exists(filePath))
			{
				try
				{
					// .NET Core / .NET 5以降では UseShellExecute = true の指定が必須です
					Process.Start(new ProcessStartInfo
					{
						FileName = filePath,
						UseShellExecute = true
					});
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ファイルを開けませんでした。\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("ライセンスファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Info_Link(object sender, EventArgs e)
		{
			Info_Label.Text = "ライセンス情報を見ることができます";
		}

		private void Button_Tutorial_Click(object sender, EventArgs e)
		{
			this.Hide();

			using (var Tutorial = new Tutorial())
			{
				Tutorial.ShowDialog();
			}

			this.Show();
		}
		
		private void Button_Hover(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				// デザイナーで設定した (Name) を取得
				string controlName = control.Name;
				switch (controlName)
				{
					case "Pic_start":
						Info_Label.Text = "一人でプレイします";
						Pic_start.Image = Properties.Resources.Solo_hover;
						break;

					case "Pic_AI":
						Info_Label.Text = "AIと対戦します";
						Pic_AI.Image = Properties.Resources.AI_hover;
						break;

					case "Pic_endless":
						Info_Label.Text = "はずれるまで無限に続きます";
						Pic_endless.Image = Properties.Resources.Endless_hover;
						break;

					case "Pic_History":
						Info_Label.Text = "これまでプレイした履歴が見れます";
						Pic_History.Image = Properties.Resources.History_hover;
						break;
				}
			}
		}

		private void Button_Leave(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				// デザイナーで設定した (Name) を取得
				string controlName = control.Name;
				switch (controlName)
				{
					case "Pic_start":
						Pic_start.Image = Properties.Resources.Solo;
						break;

					case "Pic_AI":
						Pic_AI.Image = Properties.Resources.AI;
						break;

					case "Pic_endless":
						Pic_endless.Image = Properties.Resources.Endless;
						break;

					case "Pic_History":
						Pic_History.Image = Properties.Resources.History;
						break;
				}
			}
		}

		private void Button_click(object sender, EventArgs e)
		{
			if (sender is Control control)
			{
				// デザイナーで設定した (Name) を取得
				string controlName = control.Name;

				this.Hide();
				switch (controlName)
				{
					case "Pic_start":
						using (var Game_window = new Game(false, false))
						{
							Game_window.ShowDialog();
						}

						if (Properties.Settings.Default.Warning_text)
						{
							Warning_label.Visible = true;
						}
						else
						{
							Warning_label.Visible = false;
						}
						break;

					case "Pic_AI":
						break;

					case "Pic_endless":
						using (var Game_window = new Game(true, false))
						{
							Game_window.ShowDialog();
						}

						if (Properties.Settings.Default.Warning_text)
						{
							Warning_label.Visible = true;
						}
						else
						{
							Warning_label.Visible = false;
						}
						break;

					case "Pic_History":
						using (var History = new History())
						{
							History.ShowDialog();
						}
						break;
				}

				this.Show();
			}
		}
	}
}
