namespace itacademy.gui.Dialogs
{
	partial class ProgressForm
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
			if(disposing && (components != null))
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
			this._lblText = new System.Windows.Forms.Label();
			this._progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this._lblText.AutoSize = true;
			this._lblText.Location = new System.Drawing.Point(90, 24);
			this._lblText.Name = "label1";
			this._lblText.Size = new System.Drawing.Size(35, 13);
			this._lblText.TabIndex = 0;
			this._lblText.Text = "label1";
			// 
			// progressBar1
			// 
			this._progressBar.Location = new System.Drawing.Point(12, 61);
			this._progressBar.Name = "progressBar1";
			this._progressBar.Size = new System.Drawing.Size(398, 23);
			this._progressBar.TabIndex = 1;
			// 
			// ProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 146);
			this.Controls.Add(this._progressBar);
			this.Controls.Add(this._lblText);
			this.Name = "ProgressForm";
			this.Text = "ProgressForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _lblText;
		private System.Windows.Forms.ProgressBar _progressBar;
	}
}