namespace GitHubApplication.Forms
{
    partial class GiInputBoxForm
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
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.MessageboxLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.ConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmTextBox.Location = new System.Drawing.Point(32, 68);
            this.ConfirmTextBox.Multiline = true;
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(329, 34);
            this.ConfirmTextBox.TabIndex = 1;
            // 
            // MessageboxLabel
            // 
            this.MessageboxLabel.AutoSize = true;
            this.MessageboxLabel.BackColor = System.Drawing.Color.Transparent;
            this.MessageboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageboxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MessageboxLabel.Location = new System.Drawing.Point(158, 10);
            this.MessageboxLabel.Name = "MessageboxLabel";
            this.MessageboxLabel.Size = new System.Drawing.Size(69, 18);
            this.MessageboxLabel.TabIndex = 22;
            this.MessageboxLabel.Text = "Input Box";
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.Transparent;
            this.OkButton.Image = global::GitHubApplication.Properties.Resources.confirm_button;
            this.OkButton.Location = new System.Drawing.Point(139, 141);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(107, 35);
            this.OkButton.TabIndex = 21;
            this.OkButton.TabStop = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // GiInputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.MessageBoxForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 187);
            this.Controls.Add(this.MessageboxLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ConfirmTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiInputBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForm";
            ((System.ComponentModel.ISupportInitialize)(this.OkButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Label MessageboxLabel;
        private System.Windows.Forms.PictureBox OkButton;
    }
}