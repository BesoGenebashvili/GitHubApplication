namespace GitHubApplication
{
    partial class GitHubForm
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
            this.GitHubLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TrendingRepositoriesButton = new System.Windows.Forms.Label();
            this.TrendingDevelopersButton = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.CallendarButton = new System.Windows.Forms.PictureBox();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.SearchForRepositoryesTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallendarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // GitHubLogoPictureBox
            // 
            this.GitHubLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GitHubLogoPictureBox.BackgroundImage = global::GitHubApplication.Properties.Resources.logo;
            this.GitHubLogoPictureBox.Location = new System.Drawing.Point(58, 23);
            this.GitHubLogoPictureBox.Name = "GitHubLogoPictureBox";
            this.GitHubLogoPictureBox.Size = new System.Drawing.Size(114, 36);
            this.GitHubLogoPictureBox.TabIndex = 0;
            this.GitHubLogoPictureBox.TabStop = false;
            // 
            // TrendingRepositoriesButton
            // 
            this.TrendingRepositoriesButton.AutoSize = true;
            this.TrendingRepositoriesButton.BackColor = System.Drawing.Color.Transparent;
            this.TrendingRepositoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingRepositoriesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TrendingRepositoriesButton.Location = new System.Drawing.Point(268, 33);
            this.TrendingRepositoriesButton.Name = "TrendingRepositoriesButton";
            this.TrendingRepositoriesButton.Size = new System.Drawing.Size(164, 20);
            this.TrendingRepositoriesButton.TabIndex = 1;
            this.TrendingRepositoriesButton.Text = "Trending Repositories";
            this.TrendingRepositoriesButton.Click += new System.EventHandler(this.TrendingRepositoriesButton_Click);
            // 
            // TrendingDevelopersButton
            // 
            this.TrendingDevelopersButton.AutoSize = true;
            this.TrendingDevelopersButton.BackColor = System.Drawing.Color.Transparent;
            this.TrendingDevelopersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingDevelopersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TrendingDevelopersButton.Location = new System.Drawing.Point(466, 32);
            this.TrendingDevelopersButton.Name = "TrendingDevelopersButton";
            this.TrendingDevelopersButton.Size = new System.Drawing.Size(155, 20);
            this.TrendingDevelopersButton.TabIndex = 2;
            this.TrendingDevelopersButton.Text = "Trending Developers";
            this.TrendingDevelopersButton.Click += new System.EventHandler(this.TrendingDevelopersButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Image = global::GitHubApplication.Properties.Resources.searchIcon;
            this.SearchButton.Location = new System.Drawing.Point(1023, 36);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(16, 16);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.TabStop = false;
            // 
            // CallendarButton
            // 
            this.CallendarButton.BackColor = System.Drawing.Color.Transparent;
            this.CallendarButton.Image = global::GitHubApplication.Properties.Resources.calendar;
            this.CallendarButton.Location = new System.Drawing.Point(999, 35);
            this.CallendarButton.Name = "CallendarButton";
            this.CallendarButton.Size = new System.Drawing.Size(17, 17);
            this.CallendarButton.TabIndex = 7;
            this.CallendarButton.TabStop = false;
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserPictureBox.Image = global::GitHubApplication.Properties.Resources.userIcon;
            this.UserPictureBox.Location = new System.Drawing.Point(1071, 21);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(43, 43);
            this.UserPictureBox.TabIndex = 8;
            this.UserPictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.CloseButton.Image = global::GitHubApplication.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(1158, 16);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(19, 19);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.TopButtons_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.TopButtons_MouseHover);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.MinimizeButton.Image = global::GitHubApplication.Properties.Resources.minimise;
            this.MinimizeButton.Location = new System.Drawing.Point(1136, 16);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Padding = new System.Windows.Forms.Padding(3);
            this.MinimizeButton.Size = new System.Drawing.Size(19, 19);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.TopButtons_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.TopButtons_MouseHover);
            // 
            // SearchForRepositoryesTextBox
            // 
            this.SearchForRepositoryesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.SearchForRepositoryesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchForRepositoryesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForRepositoryesTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchForRepositoryesTextBox.Location = new System.Drawing.Point(740, 33);
            this.SearchForRepositoryesTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchForRepositoryesTextBox.Name = "SearchForRepositoryesTextBox";
            this.SearchForRepositoryesTextBox.Size = new System.Drawing.Size(246, 19);
            this.SearchForRepositoryesTextBox.TabIndex = 17;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPanel.Location = new System.Drawing.Point(114, 102);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(956, 585);
            this.MainPanel.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(25, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 597);
            this.panel1.TabIndex = 33;
            // 
            // GitHubForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.mainformBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SearchForRepositoryesTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.CallendarButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TrendingDevelopersButton);
            this.Controls.Add(this.TrendingRepositoriesButton);
            this.Controls.Add(this.GitHubLogoPictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GitHubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.GitHubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GitHubLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CallendarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GitHubLogoPictureBox;
        private System.Windows.Forms.Label TrendingRepositoriesButton;
        private System.Windows.Forms.Label TrendingDevelopersButton;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.PictureBox CallendarButton;
        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.TextBox SearchForRepositoryesTextBox;
        private System.Windows.Forms.FlowLayoutPanel MainPanel;
        private System.Windows.Forms.Panel panel1;
    }
}