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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.database = new AcademicIS.database();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new FlatUI.FlatButton();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.courseSchedule = new System.Windows.Forms.DataGridView();
            this.pazartesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsamba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persembe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).BeginInit();
            this.SuspendLayout();
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
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(546, 9);
            this.editButton.Margin = new System.Windows.Forms.Padding(0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 30);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Düzenle";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(677, 9);
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 30);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // courseSchedule
            // 
            this.courseSchedule.AllowUserToAddRows = false;
            this.courseSchedule.AllowUserToDeleteRows = false;
            this.courseSchedule.AllowUserToResizeColumns = false;
            this.courseSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.courseSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.courseSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.courseSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.courseSchedule.ColumnHeadersHeight = 30;
            this.courseSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.courseSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pazartesi,
            this.sali,
            this.carsamba,
            this.persembe,
            this.cuma});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseSchedule.DefaultCellStyle = dataGridViewCellStyle8;
            this.courseSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.courseSchedule.EnableHeadersVisualStyles = false;
            this.courseSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.courseSchedule.Location = new System.Drawing.Point(12, 44);
            this.courseSchedule.Name = "courseSchedule";
            this.courseSchedule.ReadOnly = true;
            this.courseSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courseSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.courseSchedule.RowHeadersWidth = 85;
            this.courseSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.courseSchedule.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.courseSchedule.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.courseSchedule.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.courseSchedule.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(91)))), ((int)(((byte)(168)))));
            this.courseSchedule.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.courseSchedule.RowTemplate.Height = 40;
            this.courseSchedule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.courseSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.courseSchedule.ShowCellErrors = false;
            this.courseSchedule.ShowCellToolTips = false;
            this.courseSchedule.ShowEditingIcon = false;
            this.courseSchedule.ShowRowErrors = false;
            this.courseSchedule.Size = new System.Drawing.Size(771, 369);
            this.courseSchedule.TabIndex = 13;
            // 
            // pazartesi
            // 
            this.pazartesi.HeaderText = "Pazartesi";
            this.pazartesi.MaxInputLength = 100;
            this.pazartesi.Name = "pazartesi";
            this.pazartesi.ReadOnly = true;
            this.pazartesi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pazartesi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pazartesi.Width = 137;
            // 
            // sali
            // 
            this.sali.HeaderText = "Salı";
            this.sali.MaxInputLength = 100;
            this.sali.Name = "sali";
            this.sali.ReadOnly = true;
            this.sali.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sali.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sali.Width = 137;
            // 
            // carsamba
            // 
            this.carsamba.HeaderText = "Çarşamba";
            this.carsamba.MaxInputLength = 100;
            this.carsamba.Name = "carsamba";
            this.carsamba.ReadOnly = true;
            this.carsamba.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carsamba.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.carsamba.Width = 137;
            // 
            // persembe
            // 
            this.persembe.HeaderText = "Perşembe";
            this.persembe.MaxInputLength = 100;
            this.persembe.Name = "persembe";
            this.persembe.ReadOnly = true;
            this.persembe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.persembe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.persembe.Width = 137;
            // 
            // cuma
            // 
            this.cuma.HeaderText = "Cuma";
            this.cuma.MaxInputLength = 100;
            this.cuma.Name = "cuma";
            this.cuma.ReadOnly = true;
            this.cuma.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cuma.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cuma.Width = 137;
            // 
            // CourseScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(795, 425);
            this.Controls.Add(this.courseSchedule);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseScheduleForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private database database;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private FlatUI.FlatButton backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView courseSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn pazartesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sali;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsamba;
        private System.Windows.Forms.DataGridViewTextBoxColumn persembe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuma;
    }
}