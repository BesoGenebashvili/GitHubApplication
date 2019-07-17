namespace GitHubApplication
{
    partial class LoginForm
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
            this.signupLabel = new System.Windows.Forms.Label();
            this.passwordlLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.signUpButton = new System.Windows.Forms.PictureBox();
            this.notAMemberYetLabel = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.PictureBox();
            this.forgotYourPasswordLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.BackColor = System.Drawing.Color.Transparent;
            this.signupLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signupLabel.Location = new System.Drawing.Point(167, 18);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(59, 18);
            this.signupLabel.TabIndex = 19;
            this.signupLabel.Text = "Sign In";
            // 
            // passwordlLabel
            // 
            this.passwordlLabel.AutoSize = true;
            this.passwordlLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.passwordlLabel.Location = new System.Drawing.Point(25, 148);
            this.passwordlLabel.Name = "passwordlLabel";
            this.passwordlLabel.Size = new System.Drawing.Size(49, 18);
            this.passwordlLabel.TabIndex = 18;
            this.passwordlLabel.Text = "Email";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Gotham Rounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordTextBox.Location = new System.Drawing.Point(39, 182);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(325, 20);
            this.passwordTextBox.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.usernameLabel.Location = new System.Drawing.Point(25, 63);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 18);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Gotham Rounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameTextBox.Location = new System.Drawing.Point(39, 97);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(325, 20);
            this.usernameTextBox.TabIndex = 15;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.closeButton.Image = global::GitHubApplication.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(367, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(3);
            this.closeButton.Size = new System.Drawing.Size(19, 19);
            this.closeButton.TabIndex = 14;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.minimizeButton.Image = global::GitHubApplication.Properties.Resources.minimise;
            this.minimizeButton.Location = new System.Drawing.Point(349, 16);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(3);
            this.minimizeButton.Size = new System.Drawing.Size(19, 19);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signUpButton.Image = global::GitHubApplication.Properties.Resources.signUpButton;
            this.signUpButton.Location = new System.Drawing.Point(28, 358);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(344, 39);
            this.signUpButton.TabIndex = 22;
            this.signUpButton.TabStop = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // notAMemberYetLabel
            // 
            this.notAMemberYetLabel.AutoSize = true;
            this.notAMemberYetLabel.BackColor = System.Drawing.Color.Transparent;
            this.notAMemberYetLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAMemberYetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.notAMemberYetLabel.Location = new System.Drawing.Point(113, 326);
            this.notAMemberYetLabel.Name = "notAMemberYetLabel";
            this.notAMemberYetLabel.Size = new System.Drawing.Size(175, 18);
            this.notAMemberYetLabel.TabIndex = 21;
            this.notAMemberYetLabel.Text = "Not a member as yet?";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Image = global::GitHubApplication.Properties.Resources.Intermittent_line;
            this.line.Location = new System.Drawing.Point(26, 313);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(347, 2);
            this.line.TabIndex = 20;
            this.line.TabStop = false;
            // 
            // forgotYourPasswordLabel
            // 
            this.forgotYourPasswordLabel.AutoSize = true;
            this.forgotYourPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotYourPasswordLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotYourPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.forgotYourPasswordLabel.Location = new System.Drawing.Point(25, 227);
            this.forgotYourPasswordLabel.Name = "forgotYourPasswordLabel";
            this.forgotYourPasswordLabel.Size = new System.Drawing.Size(184, 18);
            this.forgotYourPasswordLabel.TabIndex = 23;
            this.forgotYourPasswordLabel.Text = "Forgot your password?";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signInButton.Image = global::GitHubApplication.Properties.Resources.signInButton;
            this.signInButton.Location = new System.Drawing.Point(28, 256);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(84, 39);
            this.signInButton.TabIndex = 24;
            this.signInButton.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.signInBG;
            this.ClientSize = new System.Drawing.Size(400, 424);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.forgotYourPasswordLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.notAMemberYetLabel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.passwordlLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Label passwordlLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox signUpButton;
        private System.Windows.Forms.Label notAMemberYetLabel;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label forgotYourPasswordLabel;
        private System.Windows.Forms.PictureBox signInButton;
    }
}