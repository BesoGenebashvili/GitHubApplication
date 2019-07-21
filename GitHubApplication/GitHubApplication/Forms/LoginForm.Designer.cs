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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.SignUpButton = new System.Windows.Forms.PictureBox();
            this.NotMemberLabel = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.PictureBox();
            this.ForgotYourPasswordButton = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.PictureBox();
            this.UserNameOrPasswordFailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.BackColor = System.Drawing.Color.Transparent;
            this.signupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signupLabel.Location = new System.Drawing.Point(171, 18);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(52, 18);
            this.signupLabel.TabIndex = 19;
            this.signupLabel.Text = "Sign In";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.PasswordLabel.Location = new System.Drawing.Point(25, 148);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 18);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 182);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(325, 19);
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.UserNameLabel.Location = new System.Drawing.Point(25, 63);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(77, 18);
            this.UserNameLabel.TabIndex = 16;
            this.UserNameLabel.Text = "Username";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.UserNameTextBox.Location = new System.Drawing.Point(39, 97);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(325, 19);
            this.UserNameTextBox.TabIndex = 15;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.CloseButton.Image = global::GitHubApplication.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(370, 16);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(19, 19);
            this.CloseButton.TabIndex = 14;
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
            this.MinimizeButton.Location = new System.Drawing.Point(349, 16);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Padding = new System.Windows.Forms.Padding(3);
            this.MinimizeButton.Size = new System.Drawing.Size(19, 19);
            this.MinimizeButton.TabIndex = 13;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.TopButtons_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.TopButtons_MouseHover);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignUpButton.Image = global::GitHubApplication.Properties.Resources.signUpButton;
            this.SignUpButton.Location = new System.Drawing.Point(28, 358);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(344, 39);
            this.SignUpButton.TabIndex = 22;
            this.SignUpButton.TabStop = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // NotMemberLabel
            // 
            this.NotMemberLabel.AutoSize = true;
            this.NotMemberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotMemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.NotMemberLabel.Location = new System.Drawing.Point(113, 326);
            this.NotMemberLabel.Name = "NotMemberLabel";
            this.NotMemberLabel.Size = new System.Drawing.Size(154, 18);
            this.NotMemberLabel.TabIndex = 21;
            this.NotMemberLabel.Text = "Not a member as yet?";
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
            // ForgotYourPasswordButton
            // 
            this.ForgotYourPasswordButton.AutoSize = true;
            this.ForgotYourPasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.ForgotYourPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotYourPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.ForgotYourPasswordButton.Location = new System.Drawing.Point(25, 227);
            this.ForgotYourPasswordButton.Name = "ForgotYourPasswordButton";
            this.ForgotYourPasswordButton.Size = new System.Drawing.Size(162, 18);
            this.ForgotYourPasswordButton.TabIndex = 23;
            this.ForgotYourPasswordButton.Text = "Forgot your password?";
            this.ForgotYourPasswordButton.Click += new System.EventHandler(this.ForgotYourPasswordButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInButton.Image = global::GitHubApplication.Properties.Resources.signInButton;
            this.SignInButton.Location = new System.Drawing.Point(28, 256);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(84, 39);
            this.SignInButton.TabIndex = 24;
            this.SignInButton.TabStop = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // UserNameOrPasswordFailLabel
            // 
            this.UserNameOrPasswordFailLabel.AutoSize = true;
            this.UserNameOrPasswordFailLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameOrPasswordFailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameOrPasswordFailLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.UserNameOrPasswordFailLabel.Location = new System.Drawing.Point(115, 266);
            this.UserNameOrPasswordFailLabel.Name = "UserNameOrPasswordFailLabel";
            this.UserNameOrPasswordFailLabel.Size = new System.Drawing.Size(223, 18);
            this.UserNameOrPasswordFailLabel.TabIndex = 23;
            this.UserNameOrPasswordFailLabel.Text = "Incorrect username or password";
            this.UserNameOrPasswordFailLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.signInBG;
            this.ClientSize = new System.Drawing.Size(400, 424);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.UserNameOrPasswordFailLabel);
            this.Controls.Add(this.ForgotYourPasswordButton);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.NotMemberLabel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox SignUpButton;
        private System.Windows.Forms.Label NotMemberLabel;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label ForgotYourPasswordButton;
        private System.Windows.Forms.PictureBox SignInButton;
        private System.Windows.Forms.Label UserNameOrPasswordFailLabel;
    }
}