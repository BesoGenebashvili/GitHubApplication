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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.SignUpButton = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.RetypePasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.TermsAndPoliciesLabel = new System.Windows.Forms.Label();
            this.TermsAndPoliciesCheckBox = new System.Windows.Forms.CheckBox();
            this.HaveAccountLabel = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.PictureBox();
            this.EmailFailedLabel = new System.Windows.Forms.Label();
            this.PasswordsFailedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignUpButton.Image = global::GitHubApplication.Properties.Resources.short_blue_button;
            this.SignUpButton.Location = new System.Drawing.Point(28, 436);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(84, 39);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.TabStop = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
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
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.MinimizeButton.Image = global::GitHubApplication.Properties.Resources.minimise;
            this.MinimizeButton.Location = new System.Drawing.Point(349, 16);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Padding = new System.Windows.Forms.Padding(3);
            this.MinimizeButton.Size = new System.Drawing.Size(19, 19);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.TopButtons_MouseLeave);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.TopButtons_MouseHover);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.ErrorImage = global::GitHubApplication.Properties.Resources.minimise;
            this.CloseButton.Image = global::GitHubApplication.Properties.Resources.close;
            this.CloseButton.Location = new System.Drawing.Point(367, 16);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(3);
            this.CloseButton.Size = new System.Drawing.Size(19, 19);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.TopButtons_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.TopButtons_MouseHover);
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
            this.UserNameTextBox.TabIndex = 4;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
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
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "Username";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.EmailLabel.Location = new System.Drawing.Point(25, 148);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 18);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.EmailTextBox.Location = new System.Drawing.Point(39, 182);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(325, 19);
            this.EmailTextBox.TabIndex = 6;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.RetypePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetypePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.RetypePasswordLabel.Location = new System.Drawing.Point(25, 318);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(125, 18);
            this.RetypePasswordLabel.TabIndex = 11;
            this.RetypePasswordLabel.Text = "Retype Password";
            // 
            // RetypePasswordTextBox
            // 
            this.RetypePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.RetypePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetypePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetypePasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.RetypePasswordTextBox.Location = new System.Drawing.Point(39, 352);
            this.RetypePasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.RetypePasswordTextBox.Name = "RetypePasswordTextBox";
            this.RetypePasswordTextBox.Size = new System.Drawing.Size(325, 19);
            this.RetypePasswordTextBox.TabIndex = 10;
            this.RetypePasswordTextBox.UseSystemPasswordChar = true;
            this.RetypePasswordTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.PasswordLabel.Location = new System.Drawing.Point(25, 233);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 18);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordTextBox.Location = new System.Drawing.Point(39, 267);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(325, 19);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SignUpLabel.Location = new System.Drawing.Point(167, 18);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(60, 18);
            this.SignUpLabel.TabIndex = 12;
            this.SignUpLabel.Text = "Sign Up";
            // 
            // TermsAndPoliciesLabel
            // 
            this.TermsAndPoliciesLabel.AutoSize = true;
            this.TermsAndPoliciesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TermsAndPoliciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsAndPoliciesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.TermsAndPoliciesLabel.Location = new System.Drawing.Point(51, 398);
            this.TermsAndPoliciesLabel.Name = "TermsAndPoliciesLabel";
            this.TermsAndPoliciesLabel.Size = new System.Drawing.Size(205, 18);
            this.TermsAndPoliciesLabel.TabIndex = 13;
            this.TermsAndPoliciesLabel.Text = "Accept the terms and policies ";
            // 
            // TermsAndPoliciesCheckBox
            // 
            this.TermsAndPoliciesCheckBox.AutoSize = true;
            this.TermsAndPoliciesCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TermsAndPoliciesCheckBox.Location = new System.Drawing.Point(29, 400);
            this.TermsAndPoliciesCheckBox.Name = "TermsAndPoliciesCheckBox";
            this.TermsAndPoliciesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.TermsAndPoliciesCheckBox.TabIndex = 14;
            this.TermsAndPoliciesCheckBox.UseVisualStyleBackColor = false;
            // 
            // HaveAccountLabel
            // 
            this.HaveAccountLabel.AutoSize = true;
            this.HaveAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.HaveAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaveAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.HaveAccountLabel.Location = new System.Drawing.Point(98, 506);
            this.HaveAccountLabel.Name = "HaveAccountLabel";
            this.HaveAccountLabel.Size = new System.Drawing.Size(176, 18);
            this.HaveAccountLabel.TabIndex = 15;
            this.HaveAccountLabel.Text = "Already have an account?";
            // 
            // SignInButton
            // 
            this.SignInButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignInButton.Image = global::GitHubApplication.Properties.Resources.long_blue_button;
            this.SignInButton.Location = new System.Drawing.Point(29, 539);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(344, 39);
            this.SignInButton.TabIndex = 16;
            this.SignInButton.TabStop = false;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // EmailFailedLabel
            // 
            this.EmailFailedLabel.AutoSize = true;
            this.EmailFailedLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailFailedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailFailedLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.EmailFailedLabel.Location = new System.Drawing.Point(85, 148);
            this.EmailFailedLabel.Name = "EmailFailedLabel";
            this.EmailFailedLabel.Size = new System.Drawing.Size(159, 18);
            this.EmailFailedLabel.TabIndex = 24;
            this.EmailFailedLabel.Text = "Email must contain \'@\'";
            this.EmailFailedLabel.Visible = false;
            // 
            // PasswordsFailedLabel
            // 
            this.PasswordsFailedLabel.AutoSize = true;
            this.PasswordsFailedLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordsFailedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordsFailedLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.PasswordsFailedLabel.Location = new System.Drawing.Point(167, 318);
            this.PasswordsFailedLabel.Name = "PasswordsFailedLabel";
            this.PasswordsFailedLabel.Size = new System.Drawing.Size(179, 18);
            this.PasswordsFailedLabel.TabIndex = 24;
            this.PasswordsFailedLabel.Text = "Passwords must be equal";
            this.PasswordsFailedLabel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::GitHubApplication.Properties.Resources.signUp_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.PasswordsFailedLabel);
            this.Controls.Add(this.EmailFailedLabel);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.HaveAccountLabel);
            this.Controls.Add(this.TermsAndPoliciesCheckBox);
            this.Controls.Add(this.TermsAndPoliciesLabel);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.RetypePasswordLabel);
            this.Controls.Add(this.RetypePasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.line);
            this.Controls.Add(this.SignUpButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.SignUpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignInButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SignUpButton;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private System.Windows.Forms.TextBox RetypePasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label TermsAndPoliciesLabel;
        private System.Windows.Forms.CheckBox TermsAndPoliciesCheckBox;
        private System.Windows.Forms.Label HaveAccountLabel;
        private System.Windows.Forms.PictureBox SignInButton;
        private System.Windows.Forms.Label EmailFailedLabel;
        private System.Windows.Forms.Label PasswordsFailedLabel;
    }
}