namespace AcademicIS {
    partial class ProfileForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.groupShortInfo = new FlatUI.FlatGroupBox();
            this.tabs = new FlatUI.FlatTabControl();
            this.tabEducation = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.telLabel = new FlatUI.FlatLabel();
            this.webLabel = new FlatUI.FlatLabel();
            this.mailLabel = new FlatUI.FlatLabel();
            this.groupImage = new FlatUI.FlatGroupBox();
            this.departmentLabel = new FlatUI.FlatLabel();
            this.facultyLabel = new FlatUI.FlatLabel();
            this.nameLabel = new FlatUI.FlatLabel();
            this.image = new System.Windows.Forms.PictureBox();
            this.backButton = new FlatUI.FlatButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.containerPanel.SuspendLayout();
            this.groupShortInfo.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabEducation.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.groupImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Controls.Add(this.flatGroupBox1);
            this.containerPanel.Controls.Add(this.groupShortInfo);
            this.containerPanel.Controls.Add(this.groupImage);
            this.containerPanel.Location = new System.Drawing.Point(12, 41);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(782, 372);
            this.containerPanel.TabIndex = 0;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(10, 276);
            this.flatGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(751, 133);
            this.flatGroupBox1.TabIndex = 4;
            // 
            // groupShortInfo
            // 
            this.groupShortInfo.BackColor = System.Drawing.Color.Transparent;
            this.groupShortInfo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.groupShortInfo.Controls.Add(this.tabs);
            this.groupShortInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupShortInfo.Location = new System.Drawing.Point(227, 10);
            this.groupShortInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupShortInfo.Name = "groupShortInfo";
            this.groupShortInfo.ShowText = true;
            this.groupShortInfo.Size = new System.Drawing.Size(534, 266);
            this.groupShortInfo.TabIndex = 1;
            // 
            // tabs
            // 
            this.tabs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tabs.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tabs.Controls.Add(this.tabEducation);
            this.tabs.Controls.Add(this.tabContact);
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabs.ItemSize = new System.Drawing.Size(130, 40);
            this.tabs.Location = new System.Drawing.Point(14, 22);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(505, 230);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            // 
            // tabEducation
            // 
            this.tabEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabEducation.Controls.Add(this.richTextBox1);
            this.tabEducation.Location = new System.Drawing.Point(4, 44);
            this.tabEducation.Name = "tabEducation";
            this.tabEducation.Padding = new System.Windows.Forms.Padding(3);
            this.tabEducation.Size = new System.Drawing.Size(497, 182);
            this.tabEducation.TabIndex = 0;
            this.tabEducation.Text = "Eğitim";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 170);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabContact
            // 
            this.tabContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabContact.Controls.Add(this.flatLabel1);
            this.tabContact.Controls.Add(this.flatLabel2);
            this.tabContact.Controls.Add(this.flatLabel3);
            this.tabContact.Controls.Add(this.telLabel);
            this.tabContact.Controls.Add(this.webLabel);
            this.tabContact.Controls.Add(this.mailLabel);
            this.tabContact.Location = new System.Drawing.Point(4, 44);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(497, 182);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "İletişim";
            // 
            // flatLabel1
            // 
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(20, 63);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(90, 23);
            this.flatLabel1.TabIndex = 8;
            this.flatLabel1.Text = "Telefon:";
            // 
            // flatLabel2
            // 
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(20, 40);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(90, 23);
            this.flatLabel2.TabIndex = 7;
            this.flatLabel2.Text = "Web sayfası:";
            // 
            // flatLabel3
            // 
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(20, 17);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(76, 23);
            this.flatLabel3.TabIndex = 6;
            this.flatLabel3.Text = "E-posta:";
            // 
            // telLabel
            // 
            this.telLabel.BackColor = System.Drawing.Color.Transparent;
            this.telLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telLabel.ForeColor = System.Drawing.Color.White;
            this.telLabel.Location = new System.Drawing.Point(116, 63);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(375, 23);
            this.telLabel.TabIndex = 5;
            this.telLabel.Text = "00000000000";
            // 
            // webLabel
            // 
            this.webLabel.BackColor = System.Drawing.Color.Transparent;
            this.webLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.webLabel.ForeColor = System.Drawing.Color.White;
            this.webLabel.Location = new System.Drawing.Point(116, 40);
            this.webLabel.Name = "webLabel";
            this.webLabel.Size = new System.Drawing.Size(375, 23);
            this.webLabel.TabIndex = 4;
            this.webLabel.Text = "http://domain.com/";
            // 
            // mailLabel
            // 
            this.mailLabel.BackColor = System.Drawing.Color.Transparent;
            this.mailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailLabel.ForeColor = System.Drawing.Color.White;
            this.mailLabel.Location = new System.Drawing.Point(116, 17);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(375, 23);
            this.mailLabel.TabIndex = 3;
            this.mailLabel.Text = "xxx@xxx.com";
            // 
            // groupImage
            // 
            this.groupImage.BackColor = System.Drawing.Color.Transparent;
            this.groupImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.groupImage.Controls.Add(this.departmentLabel);
            this.groupImage.Controls.Add(this.facultyLabel);
            this.groupImage.Controls.Add(this.nameLabel);
            this.groupImage.Controls.Add(this.image);
            this.groupImage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupImage.Location = new System.Drawing.Point(10, 10);
            this.groupImage.Margin = new System.Windows.Forms.Padding(0);
            this.groupImage.Name = "groupImage";
            this.groupImage.ShowText = true;
            this.groupImage.Size = new System.Drawing.Size(217, 266);
            this.groupImage.TabIndex = 0;
            // 
            // departmentLabel
            // 
            this.departmentLabel.BackColor = System.Drawing.Color.Transparent;
            this.departmentLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.departmentLabel.ForeColor = System.Drawing.Color.White;
            this.departmentLabel.Location = new System.Drawing.Point(18, 230);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(182, 23);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Bölüm Adı";
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facultyLabel
            // 
            this.facultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.facultyLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.facultyLabel.ForeColor = System.Drawing.Color.White;
            this.facultyLabel.Location = new System.Drawing.Point(18, 207);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(182, 23);
            this.facultyLabel.TabIndex = 2;
            this.facultyLabel.Text = "Fakulte Adı";
            this.facultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(18, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(182, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "İsim Soyisim";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // image
            // 
            this.image.ErrorImage = null;
            this.image.InitialImage = null;
            this.image.Location = new System.Drawing.Point(45, 22);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(125, 150);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backButton.Location = new System.Drawing.Point(12, 5);
            this.backButton.Name = "backButton";
            this.backButton.Rounded = false;
            this.backButton.Size = new System.Drawing.Size(106, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "< Geri";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteButton.Location = new System.Drawing.Point(667, 5);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editButton.Location = new System.Drawing.Point(536, 5);
            this.editButton.Margin = new System.Windows.Forms.Padding(0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 30);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Düzenle";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.containerPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.containerPanel.ResumeLayout(false);
            this.groupShortInfo.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabEducation.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.groupImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerPanel;
        private FlatUI.FlatButton backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private FlatUI.FlatGroupBox groupImage;
        private System.Windows.Forms.PictureBox image;
        private FlatUI.FlatGroupBox groupShortInfo;
        private FlatUI.FlatLabel nameLabel;
        private FlatUI.FlatLabel departmentLabel;
        private FlatUI.FlatLabel facultyLabel;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private FlatUI.FlatTabControl tabs;
        private System.Windows.Forms.TabPage tabEducation;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabContact;
        private FlatUI.FlatLabel telLabel;
        private FlatUI.FlatLabel webLabel;
        private FlatUI.FlatLabel mailLabel;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel3;
    }
}