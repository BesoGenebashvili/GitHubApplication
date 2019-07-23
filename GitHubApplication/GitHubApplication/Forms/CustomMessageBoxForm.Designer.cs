namespace GitHubApplication.Forms
{
    partial class CustomMessageBox
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
            this.OkButton = new System.Windows.Forms.PictureBox();
            this.MessageboxLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Transparent;
            this.OkButton.Image = global::GitHubCore.Properties.Resources.ok_Button;
            this.OkButton.Location = new System.Drawing.Point(139, 141);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 35);
            this.OkButton.TabIndex = 0;
            this.OkButton.TabStop = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MessageboxLabel
            // 
            this.MessageboxLabel.AutoSize = true;
            this.MessageboxLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageboxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageboxLabel.Location = new System.Drawing.Point(143, 10);
            this.MessageboxLabel.Name = "MessageboxLabel";
            this.MessageboxLabel.Size = new System.Drawing.Size(99, 18);
            this.MessageboxLabel.TabIndex = 20;
            this.MessageboxLabel.Text = "Message Box";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageLabel.Location = new System.Drawing.Point(0, 83);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(384, 17);
            this.MessageLabel.TabIndex = 21;
            this.MessageLabel.Text = "your text";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GitHubCore.Properties.Resources.MessageBoxForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageboxLabel);
            this.Controls.Add(this.OkButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OkButton;
        private System.Windows.Forms.Label MessageboxLabel;
        private System.Windows.Forms.Label MessageLabel;
    }
}