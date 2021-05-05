
using System;

namespace AllOfUsLauncher
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.header = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.version_text = new System.Windows.Forms.Label();
            this.UpdateGame = new System.Windows.Forms.Button();
            this.CheckUpdate = new System.Windows.Forms.Button();
            this.UpdateInfo = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadStatus = new System.Windows.Forms.Label();
            this.InstallGame = new System.Windows.Forms.Button();
            this.UninstallGame = new System.Windows.Forms.Button();
            this.AmongUSDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.Location = new System.Drawing.Point(23, 20);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(259, 89);
            this.header.TabIndex = 1;
            this.header.Text = "AllOfUs";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.Transparent;
            this.version_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.version_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.version_label.Location = new System.Drawing.Point(630, 20);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(80, 28);
            this.version_label.TabIndex = 2;
            this.version_label.Text = "Version:";
            // 
            // version_text
            // 
            this.version_text.AutoSize = true;
            this.version_text.BackColor = System.Drawing.Color.Transparent;
            this.version_text.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.version_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.version_text.Location = new System.Drawing.Point(716, 20);
            this.version_text.Name = "version_text";
            this.version_text.Size = new System.Drawing.Size(53, 28);
            this.version_text.TabIndex = 3;
            this.version_text.Text = "0.0.0";
            // 
            // UpdateGame
            // 
            this.UpdateGame.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateGame.Location = new System.Drawing.Point(610, 371);
            this.UpdateGame.Name = "UpdateGame";
            this.UpdateGame.Size = new System.Drawing.Size(145, 36);
            this.UpdateGame.TabIndex = 4;
            this.UpdateGame.Text = "UPDATE";
            this.UpdateGame.UseVisualStyleBackColor = true;
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckUpdate.Location = new System.Drawing.Point(610, 276);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(145, 26);
            this.CheckUpdate.TabIndex = 5;
            this.CheckUpdate.Text = "Check update";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.AutoSize = true;
            this.UpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.UpdateInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateInfo.Location = new System.Drawing.Point(610, 254);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(122, 19);
            this.UpdateInfo.TabIndex = 6;
            this.UpdateInfo.Text = "Update not found.";
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(610, 371);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(145, 39);
            this.PlayButton.TabIndex = 8;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(23, 385);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(435, 22);
            this.ProgressBar.TabIndex = 9;
            // 
            // DownloadStatus
            // 
            this.DownloadStatus.AutoSize = true;
            this.DownloadStatus.BackColor = System.Drawing.Color.Transparent;
            this.DownloadStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownloadStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DownloadStatus.Location = new System.Drawing.Point(23, 363);
            this.DownloadStatus.Name = "DownloadStatus";
            this.DownloadStatus.Size = new System.Drawing.Size(151, 19);
            this.DownloadStatus.TabIndex = 10;
            this.DownloadStatus.Text = "Installing AllOfUs 0.0.0.";
            // 
            // InstallGame
            // 
            this.InstallGame.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstallGame.Location = new System.Drawing.Point(610, 372);
            this.InstallGame.Name = "InstallGame";
            this.InstallGame.Size = new System.Drawing.Size(145, 36);
            this.InstallGame.TabIndex = 13;
            this.InstallGame.Text = "INSTALL";
            this.InstallGame.UseVisualStyleBackColor = true;
            this.InstallGame.Click += new System.EventHandler(this.InstallGame_Click);
            // 
            // UninstallGame
            // 
            this.UninstallGame.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UninstallGame.Location = new System.Drawing.Point(478, 385);
            this.UninstallGame.Name = "UninstallGame";
            this.UninstallGame.Size = new System.Drawing.Size(111, 22);
            this.UninstallGame.TabIndex = 14;
            this.UninstallGame.Text = "UNINSTALL";
            this.UninstallGame.UseVisualStyleBackColor = true;
            this.UninstallGame.Click += new System.EventHandler(this.UninstallGame_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UninstallGame);
            this.Controls.Add(this.InstallGame);
            this.Controls.Add(this.DownloadStatus);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.UpdateInfo);
            this.Controls.Add(this.CheckUpdate);
            this.Controls.Add(this.UpdateGame);
            this.Controls.Add(this.version_text);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.header);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainPanel";
            this.Text = "AllOfUs | Launcher";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label version_text;
        private System.Windows.Forms.Button UpdateGame;
        private System.Windows.Forms.Button CheckUpdate;
        private System.Windows.Forms.Label UpdateInfo;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label DownloadStatus;
        private System.Windows.Forms.Button InstallGame;
        private System.Windows.Forms.Button UninstallGame;
        private System.Windows.Forms.FolderBrowserDialog AmongUSDirectory;
    }
}