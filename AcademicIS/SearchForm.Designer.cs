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
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatComboBox2 = new FlatUI.FlatComboBox();
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
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(623, 26);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(160, 29);
            this.flatTextBox1.TabIndex = 1;
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
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
            // flatComboBox1
            // 
            this.flatComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox1.ForeColor = System.Drawing.Color.White;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox1.ItemHeight = 18;
            this.flatComboBox1.Location = new System.Drawing.Point(72, 26);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(160, 24);
            this.flatComboBox1.TabIndex = 3;
            // 
            // flatComboBox2
            // 
            this.flatComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox2.ForeColor = System.Drawing.Color.White;
            this.flatComboBox2.FormattingEnabled = true;
            this.flatComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox2.ItemHeight = 18;
            this.flatComboBox2.Location = new System.Drawing.Point(336, 26);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(160, 24);
            this.flatComboBox2.TabIndex = 5;
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
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.listPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listPanel.ForeColor = System.Drawing.Color.White;
            this.listPanel.Location = new System.Drawing.Point(72, 99);
            this.listPanel.MaximumSize = new System.Drawing.Size(700, 300);
            this.listPanel.MinimumSize = new System.Drawing.Size(450, 30);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 1;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.listPanel.Size = new System.Drawing.Size(672, 298);
            this.listPanel.TabIndex = 6;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.flatComboBox2);
            this.Controls.Add(this.flatLabel2);
            this.Controls.Add(this.flatComboBox1);
            this.Controls.Add(this.flatLabel1);
            this.Controls.Add(this.flatTextBox1);
            this.Controls.Add(this.labelName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatLabel labelName;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatComboBox flatComboBox2;
        private FlatUI.FlatLabel flatLabel2;
        private System.Windows.Forms.TableLayoutPanel listPanel;
    }
}