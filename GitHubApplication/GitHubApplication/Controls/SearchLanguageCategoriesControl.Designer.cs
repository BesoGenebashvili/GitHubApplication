namespace GitHubApplication.Controls
{
    partial class SearchLanguageCategoriesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LanguageNameButton = new System.Windows.Forms.Label();
            this.LanguageColorPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LanguageNameButton
            // 
            this.LanguageNameButton.BackColor = System.Drawing.Color.Transparent;
            this.LanguageNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.LanguageNameButton.Location = new System.Drawing.Point(3, 2);
            this.LanguageNameButton.Name = "LanguageNameButton";
            this.LanguageNameButton.Size = new System.Drawing.Size(95, 17);
            this.LanguageNameButton.TabIndex = 5;
            this.LanguageNameButton.Text = "JavaScript";
            this.LanguageNameButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LanguageNameButton.Click += new System.EventHandler(this.LanguageNameButton_Click);
            // 
            // LanguageColorPictureBox
            // 
            this.LanguageColorPictureBox.Image = global::GitHubApplication.Properties.Resources.C;
            this.LanguageColorPictureBox.Location = new System.Drawing.Point(104, 9);
            this.LanguageColorPictureBox.Name = "LanguageColorPictureBox";
            this.LanguageColorPictureBox.Size = new System.Drawing.Size(5, 5);
            this.LanguageColorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LanguageColorPictureBox.TabIndex = 4;
            this.LanguageColorPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitHubApplication.Properties.Resources.searchItemTopLine;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SearchLanguageCategoriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LanguageColorPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LanguageNameButton);
            this.Name = "SearchLanguageCategoriesControl";
            this.Size = new System.Drawing.Size(110, 17);
            ((System.ComponentModel.ISupportInitialize)(this.LanguageColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LanguageNameButton;
        private System.Windows.Forms.PictureBox LanguageColorPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
