namespace AcademicIS
{
    partial class CourseScheduleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.courseSchedule = new System.Windows.Forms.DataGridView();
            this.database = new AcademicIS.database();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new FlatUI.FlatButton();
            this.Pazartesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Çarşamba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perşembe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseSchedule
            // 
            this.courseSchedule.AllowUserToAddRows = false;
            this.courseSchedule.AllowUserToDeleteRows = false;
            this.courseSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.courseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pazartesi,
            this.Salı,
            this.Çarşamba,
            this.Perşembe,
            this.Cuma});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.courseSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.courseSchedule.Location = new System.Drawing.Point(73, 56);
            this.courseSchedule.Name = "courseSchedule";
            this.courseSchedule.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = "09:00 - 09:45";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.courseSchedule.RowHeadersWidth = 80;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.NullValue = null;
            this.courseSchedule.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.courseSchedule.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.courseSchedule.RowTemplate.Height = 35;
            this.courseSchedule.Size = new System.Drawing.Size(710, 358);
            this.courseSchedule.TabIndex = 0;
            // 
            // database
            // 
            this.database.DataSetName = "database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = this.database;
            this.databaseBindingSource.Position = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backButton.Location = new System.Drawing.Point(12, 8);
            this.backButton.Name = "backButton";
            this.backButton.Rounded = false;
            this.backButton.Size = new System.Drawing.Size(106, 30);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "< Geri";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // Pazartesi
            // 
            this.Pazartesi.HeaderText = "Pazartesi";
            this.Pazartesi.Name = "Pazartesi";
            this.Pazartesi.ReadOnly = true;
            this.Pazartesi.Width = 125;
            // 
            // Salı
            // 
            this.Salı.HeaderText = "Salı";
            this.Salı.Name = "Salı";
            this.Salı.ReadOnly = true;
            this.Salı.Width = 125;
            // 
            // Çarşamba
            // 
            this.Çarşamba.HeaderText = "Çarşamba";
            this.Çarşamba.Name = "Çarşamba";
            this.Çarşamba.ReadOnly = true;
            this.Çarşamba.Width = 125;
            // 
            // Perşembe
            // 
            this.Perşembe.HeaderText = "Perşembe";
            this.Perşembe.Name = "Perşembe";
            this.Perşembe.ReadOnly = true;
            this.Perşembe.Width = 125;
            // 
            // Cuma
            // 
            this.Cuma.HeaderText = "Cuma";
            this.Cuma.Name = "Cuma";
            this.Cuma.ReadOnly = true;
            this.Cuma.Width = 125;
            // 
            // CourseScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.courseSchedule);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseScheduleForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseSchedule;
        private database database;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private FlatUI.FlatButton backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pazartesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Çarşamba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perşembe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuma;
    }
}