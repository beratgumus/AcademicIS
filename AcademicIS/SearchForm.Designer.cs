namespace AcademicIS {
    partial class SearchForm {
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
            this.labelName = new FlatUI.FlatLabel();
            this.searchBox = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.facultyCB = new FlatUI.FlatComboBox();
            this.departmentCB = new FlatUI.FlatComboBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.listPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(539, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 51);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "İsme göre  filtreleme";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.FocusOnHover = false;
            this.searchBox.Location = new System.Drawing.Point(623, 26);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            this.searchBox.ReadOnly = false;
            this.searchBox.Size = new System.Drawing.Size(160, 29);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.TextChanged += new System.EventHandler(this.ApplyFilters);
            // 
            // flatLabel1
            // 
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 26);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(67, 29);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Fakülte";
            // 
            // facultyCB
            // 
            this.facultyCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.facultyCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.facultyCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.facultyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyCB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.facultyCB.ForeColor = System.Drawing.Color.White;
            this.facultyCB.FormattingEnabled = true;
            this.facultyCB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.facultyCB.ItemHeight = 18;
            this.facultyCB.Items.AddRange(new object[] {
            "Hepsi"});
            this.facultyCB.Location = new System.Drawing.Point(72, 26);
            this.facultyCB.Name = "facultyCB";
            this.facultyCB.Size = new System.Drawing.Size(160, 24);
            this.facultyCB.TabIndex = 3;
            this.facultyCB.SelectedIndexChanged += new System.EventHandler(this.ApplyFilters);
            // 
            // departmentCB
            // 
            this.departmentCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.departmentCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departmentCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentCB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.departmentCB.ForeColor = System.Drawing.Color.White;
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.departmentCB.ItemHeight = 18;
            this.departmentCB.Items.AddRange(new object[] {
            "Hepsi"});
            this.departmentCB.Location = new System.Drawing.Point(336, 26);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(160, 24);
            this.departmentCB.TabIndex = 5;
            this.departmentCB.SelectedIndexChanged += new System.EventHandler(this.ApplyFilters);
            // 
            // flatLabel2
            // 
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(276, 26);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(67, 29);
            this.flatLabel2.TabIndex = 4;
            this.flatLabel2.Text = "Bölüm";
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.AutoSize = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.listPanel.ColumnCount = 3;
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.82738F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.17262F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.listPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listPanel.ForeColor = System.Drawing.Color.White;
            this.listPanel.Location = new System.Drawing.Point(16, 103);
            this.listPanel.MaximumSize = new System.Drawing.Size(725, 300);
            this.listPanel.MinimumSize = new System.Drawing.Size(450, 30);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 1;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listPanel.Size = new System.Drawing.Size(725, 298);
            this.listPanel.TabIndex = 6;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.facultyCB);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatLabel labelName;
        private FlatUI.FlatTextBox searchBox;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatComboBox facultyCB;
        private FlatUI.FlatComboBox departmentCB;
        private FlatUI.FlatLabel flatLabel2;
        private System.Windows.Forms.TableLayoutPanel listPanel;
    }
}