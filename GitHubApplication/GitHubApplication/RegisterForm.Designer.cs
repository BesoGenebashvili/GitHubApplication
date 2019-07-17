namespace GitHubApplication
{
    partial class RegisterForm
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
            this.signUpButton = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.retypePasswordLabel = new System.Windows.Forms.Label();
            this.retypePasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.signupLabel = new System.Windows.Forms.Label();
            this.termsAndPoliciesLabel = new System.Windows.Forms.Label();
            this.termsAndPoliciesCheckBox = new System.Windows.Forms.CheckBox();
            this.alreadyHaveAnAccountLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signUpButton.Image = global::GitHubApplication.Properties.Resources.short_blue_button;
            this.signUpButton.Location = new System.Drawing.Point(28, 436);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(84, 39);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.Image = global::GitHubApplication.Properties.Resources.Intermittent_line;
            this.line.Location = new System.Drawing.Point(27, 494);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(347, 2);
            this.line.TabIndex = 1;
            this.line.TabStop = false;
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
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            this.minimizeButton.MouseLeave += new System.EventHandler(this.topButtons_MouseLeave);
            this.minimizeButton.MouseHover += new System.EventHandler(this.topButtons_MouseHover);
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
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.topButtons_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.topButtons_MouseHover);
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
            this.usernameTextBox.TabIndex = 4;
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
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.emailLabel.Location = new System.Drawing.Point(25, 148);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(49, 18);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Gotham Rounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.emailTextBox.Location = new System.Drawing.Point(39, 182);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(325, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // retypePasswordLabel
            // 
            this.retypePasswordLabel.AutoSize = true;
            this.retypePasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.retypePasswordLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.retypePasswordLabel.Location = new System.Drawing.Point(25, 318);
            this.retypePasswordLabel.Name = "retypePasswordLabel";
            this.retypePasswordLabel.Size = new System.Drawing.Size(139, 18);
            this.retypePasswordLabel.TabIndex = 11;
            this.retypePasswordLabel.Text = "Retype Password";
            // 
            // retypePasswordTextBox
            // 
            this.retypePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.retypePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.retypePasswordTextBox.Font = new System.Drawing.Font("Gotham Rounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.retypePasswordTextBox.Location = new System.Drawing.Point(39, 352);
            this.retypePasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.retypePasswordTextBox.Name = "retypePasswordTextBox";
            this.retypePasswordTextBox.Size = new System.Drawing.Size(325, 20);
            this.retypePasswordTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.passwordLabel.Location = new System.Drawing.Point(25, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 18);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Gotham Rounded Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 267);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(325, 20);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.BackColor = System.Drawing.Color.Transparent;
            this.signupLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signupLabel.Location = new System.Drawing.Point(167, 18);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(67, 18);
            this.signupLabel.TabIndex = 12;
            this.signupLabel.Text = "Sign Up";
            // 
            // termsAndPoliciesLabel
            // 
            this.termsAndPoliciesLabel.AutoSize = true;
            this.termsAndPoliciesLabel.BackColor = System.Drawing.Color.Transparent;
            this.termsAndPoliciesLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsAndPoliciesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.termsAndPoliciesLabel.Location = new System.Drawing.Point(51, 398);
            this.termsAndPoliciesLabel.Name = "termsAndPoliciesLabel";
            this.termsAndPoliciesLabel.Size = new System.Drawing.Size(239, 18);
            this.termsAndPoliciesLabel.TabIndex = 13;
            this.termsAndPoliciesLabel.Text = "Accept the terms and policies ";
            // 
            // termsAndPoliciesCheckBox
            // 
            this.termsAndPoliciesCheckBox.AutoSize = true;
            this.termsAndPoliciesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.termsAndPoliciesCheckBox.Location = new System.Drawing.Point(29, 400);
            this.termsAndPoliciesCheckBox.Name = "termsAndPoliciesCheckBox";
            this.termsAndPoliciesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.termsAndPoliciesCheckBox.TabIndex = 14;
            this.termsAndPoliciesCheckBox.UseVisualStyleBackColor = false;
            // 
            // alreadyHaveAnAccountLabel
            // 
            this.alreadyHaveAnAccountLabel.AutoSize = true;
            this.alreadyHaveAnAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.alreadyHaveAnAccountLabel.Font = new System.Drawing.Font("Gotham Rounded Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alreadyHaveAnAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.alreadyHaveAnAccountLabel.Location = new System.Drawing.Point(98, 506);
            this.alreadyHaveAnAccountLabel.Name = "alreadyHaveAnAccountLabel";
            this.alreadyHaveAnAccountLabel.Size = new System.Drawing.Size(205, 18);
            this.alreadyHaveAnAccountLabel.TabIndex = 15;
            this.alreadyHaveAnAccountLabel.Text = "Already have an account?";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Transparent;
            this.signInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signInButton.Image = global::GitHubApplication.Properties.Resources.long_blue_button;
            this.signInButton.Location = new System.Drawing.Point(29, 539);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(344, 39);
            this.signInButton.TabIndex = 16;
            this.signInButton.TabStop = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.signUp_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.alreadyHaveAnAccountLabel);
            this.Controls.Add(this.termsAndPoliciesCheckBox);
            this.Controls.Add(this.termsAndPoliciesLabel);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.retypePasswordLabel);
            this.Controls.Add(this.retypePasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.line);
            this.Controls.Add(this.signUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.signUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox signUpButton;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label retypePasswordLabel;
        private System.Windows.Forms.TextBox retypePasswordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Label termsAndPoliciesLabel;
        private System.Windows.Forms.CheckBox termsAndPoliciesCheckBox;
        private System.Windows.Forms.Label alreadyHaveAnAccountLabel;
        private System.Windows.Forms.PictureBox signInButton;
    }
}