namespace Rhytmious
{
	partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShortInfoLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.RepoLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(256, 256);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(280, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(302, 44);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Rhytmious";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShortInfoLabel
            // 
            this.ShortInfoLabel.Location = new System.Drawing.Point(277, 79);
            this.ShortInfoLabel.Name = "ShortInfoLabel";
            this.ShortInfoLabel.Size = new System.Drawing.Size(305, 23);
            this.ShortInfoLabel.TabIndex = 2;
            this.ShortInfoLabel.Text = "Simple and user-friendly metronome for Windows";
            this.ShortInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(277, 102);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(305, 23);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Code and design by Ivan Movchan, 2023";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKButton
            // 
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(274, 245);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(302, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(277, 56);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(305, 23);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Version 0.0 (01.01.1970 0:00:00)";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepoLinkLabel
            // 
            this.RepoLinkLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepoLinkLabel.Location = new System.Drawing.Point(280, 214);
            this.RepoLinkLabel.Name = "RepoLinkLabel";
            this.RepoLinkLabel.Size = new System.Drawing.Size(302, 28);
            this.RepoLinkLabel.TabIndex = 8;
            this.RepoLinkLabel.TabStop = true;
            this.RepoLinkLabel.Text = "https://github.com/AngelOfV0id/Rhytmious";
            this.RepoLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RepoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RepoLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 281);
            this.Controls.Add(this.RepoLinkLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.ShortInfoLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 540);
            this.MinimumSize = new System.Drawing.Size(600, 310);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Rhytmious...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutForm_FormClosing);
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox LogoPictureBox;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label ShortInfoLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel RepoLinkLabel;
    }
}