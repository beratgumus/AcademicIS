namespace AcademicIS {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.headerBG = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerText = new FlatUI.FlatLabel();
            this.formMinimize = new FlatUI.FlatMini();
            this.formClose = new FlatUI.FlatClose();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderRight = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.loadingText = new FlatUI.FlatLabel();
            this.spinner = new System.Windows.Forms.PictureBox();
            this.loading = new AcademicIS.Fade();
            this.menu.SuspendLayout();
            this.headerBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearch,
            this.menuLogin});
            this.menu.Location = new System.Drawing.Point(-1, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(802, 30);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // menuSearch
            // 
            this.menuSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(111, 26);
            this.menuSearch.Text = "Akademisyen Ara";
            this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(90, 26);
            this.menuLogin.Text = "Yönetici Girişi";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // headerBG
            // 
            this.headerBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.headerBG.Controls.Add(this.panel3);
            this.headerBG.Controls.Add(this.panel2);
            this.headerBG.Controls.Add(this.panel1);
            this.headerBG.Controls.Add(this.headerText);
            this.headerBG.Controls.Add(this.formMinimize);
            this.headerBG.Controls.Add(this.formClose);
            this.headerBG.Location = new System.Drawing.Point(-1, -1);
            this.headerBG.Name = "headerBG";
            this.headerBG.Size = new System.Drawing.Size(802, 50);
            this.headerBG.TabIndex = 3;
            this.headerBG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.headerBG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.headerBG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel3.Location = new System.Drawing.Point(36, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 30);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel2.Location = new System.Drawing.Point(25, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 30);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel1.Location = new System.Drawing.Point(14, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 3;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.BackColor = System.Drawing.Color.Transparent;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(47, 11);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(186, 21);
            this.headerText.TabIndex = 2;
            this.headerText.Text = "Akademik Bilgi Sistemi";
            this.headerText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.headerText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.headerText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // formMinimize
            // 
            this.formMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formMinimize.BackColor = System.Drawing.Color.White;
            this.formMinimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formMinimize.Font = new System.Drawing.Font("Marlett", 12F);
            this.formMinimize.Location = new System.Drawing.Point(746, 14);
            this.formMinimize.Name = "formMinimize";
            this.formMinimize.Size = new System.Drawing.Size(18, 18);
            this.formMinimize.TabIndex = 1;
            this.formMinimize.Text = "flatMini1";
            this.formMinimize.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // formClose
            // 
            this.formClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.formClose.BackColor = System.Drawing.Color.White;
            this.formClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.formClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.formClose.Location = new System.Drawing.Point(770, 14);
            this.formClose.Name = "formClose";
            this.formClose.Size = new System.Drawing.Size(18, 18);
            this.formClose.TabIndex = 0;
            this.formClose.Text = "flatClose1";
            this.formClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.borderLeft.Location = new System.Drawing.Point(0, 70);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(5, 432);
            this.borderLeft.TabIndex = 4;
            // 
            // borderRight
            // 
            this.borderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.borderRight.Location = new System.Drawing.Point(796, 70);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(5, 432);
            this.borderRight.TabIndex = 5;
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.borderBottom.Location = new System.Drawing.Point(-1, 496);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(802, 5);
            this.borderBottom.TabIndex = 6;
            // 
            // delay
            // 
            this.delay.Interval = 200;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // loadingText
            // 
            this.loadingText.AutoSize = true;
            this.loadingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.loadingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(28)))));
            this.loadingText.Location = new System.Drawing.Point(354, 318);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(103, 21);
            this.loadingText.TabIndex = 11;
            this.loadingText.Text = "Yükleniyor...";
            // 
            // spinner
            // 
            this.spinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.spinner.ErrorImage = null;
            this.spinner.Location = new System.Drawing.Point(340, 163);
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(128, 132);
            this.spinner.TabIndex = 10;
            this.spinner.TabStop = false;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.loading.Location = new System.Drawing.Point(5, 72);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(791, 424);
            this.loading.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.headerBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Akademik Bilgi Sistemi";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.headerBG.ResumeLayout(false);
            this.headerBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.Panel headerBG;
        private FlatUI.FlatMini formMinimize;
        private FlatUI.FlatClose formClose;
        private System.Windows.Forms.Panel borderLeft;
        private System.Windows.Forms.Panel borderRight;
        private System.Windows.Forms.Panel borderBottom;
        private FlatUI.FlatLabel headerText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Fade loading;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.PictureBox spinner;
        private FlatUI.FlatLabel loadingText;
    }
}

