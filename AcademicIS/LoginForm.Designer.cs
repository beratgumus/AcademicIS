namespace AcademicIS
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
            this.loginButton = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.username = new FlatUI.FlatTextBox();
            this.password = new FlatUI.FlatTextBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loginButton.Location = new System.Drawing.Point(317, 256);
            this.loginButton.Name = "loginButton";
            this.loginButton.Rounded = false;
            this.loginButton.Size = new System.Drawing.Size(106, 32);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(174, 159);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(95, 20);
            this.flatLabel1.TabIndex = 1;
            this.flatLabel1.Text = "Kullanıcı Adı:";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(227, 207);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(42, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Şifre:";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.FocusOnHover = false;
            this.username.Location = new System.Drawing.Point(275, 159);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(186, 29);
            this.username.TabIndex = 3;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.username.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.AccessibleName = "";
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.FocusOnHover = false;
            this.password.Location = new System.Drawing.Point(275, 207);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(186, 29);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.password.UseSystemPasswordChar = true;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(296, 74);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(127, 25);
            this.flatLabel3.TabIndex = 5;
            this.flatLabel3.Text = "Yönetici Girişi";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.flatLabel3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatButton loginButton;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox username;
        private FlatUI.FlatTextBox password;
        private FlatUI.FlatLabel flatLabel3;
    }
}