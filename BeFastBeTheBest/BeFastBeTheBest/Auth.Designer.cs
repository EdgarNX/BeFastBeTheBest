namespace BeFastBeTheBest
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.groupBoxSignUp = new System.Windows.Forms.GroupBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxSignUpPassword = new System.Windows.Forms.TextBox();
            this.textBoxSignUpName = new System.Windows.Forms.TextBox();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxLoginPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxLoginName);
            this.groupBoxLogin.Controls.Add(this.labelLogin);
            this.groupBoxLogin.Location = new System.Drawing.Point(144, 145);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogin.Size = new System.Drawing.Size(375, 391);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(78, 288);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(212, 52);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(78, 207);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(212, 22);
            this.textBoxLoginPassword.TabIndex = 2;
            this.textBoxLoginPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(78, 132);
            this.textBoxLoginName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(212, 22);
            this.textBoxLoginName.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(128, 55);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(101, 38);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // groupBoxSignUp
            // 
            this.groupBoxSignUp.Controls.Add(this.buttonSignUp);
            this.groupBoxSignUp.Controls.Add(this.textBoxSignUpPassword);
            this.groupBoxSignUp.Controls.Add(this.textBoxSignUpName);
            this.groupBoxSignUp.Controls.Add(this.labelSignUp);
            this.groupBoxSignUp.Location = new System.Drawing.Point(662, 145);
            this.groupBoxSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSignUp.Name = "groupBoxSignUp";
            this.groupBoxSignUp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSignUp.Size = new System.Drawing.Size(375, 391);
            this.groupBoxSignUp.TabIndex = 1;
            this.groupBoxSignUp.TabStop = false;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignUp.Location = new System.Drawing.Point(78, 288);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(219, 52);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxSignUpPassword
            // 
            this.textBoxSignUpPassword.Location = new System.Drawing.Point(78, 207);
            this.textBoxSignUpPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSignUpPassword.Name = "textBoxSignUpPassword";
            this.textBoxSignUpPassword.Size = new System.Drawing.Size(219, 22);
            this.textBoxSignUpPassword.TabIndex = 3;
            this.textBoxSignUpPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSignUpName
            // 
            this.textBoxSignUpName.Location = new System.Drawing.Point(78, 132);
            this.textBoxSignUpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSignUpName.Name = "textBoxSignUpName";
            this.textBoxSignUpName.Size = new System.Drawing.Size(219, 22);
            this.textBoxSignUpName.TabIndex = 2;
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.Location = new System.Drawing.Point(114, 55);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(140, 38);
            this.labelSignUp.TabIndex = 1;
            this.labelSignUp.Text = "Sign Up";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(728, -978);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 830);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 783);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBoxSignUp);
            this.Controls.Add(this.groupBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1199, 899);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1199, 830);
            this.Name = "Auth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthenticationPage";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSignUp.ResumeLayout(false);
            this.groupBoxSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxSignUp;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.TextBox textBoxSignUpPassword;
        private System.Windows.Forms.TextBox textBoxSignUpName;
        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogin;
    }
}

