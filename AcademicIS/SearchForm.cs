﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS {
    public partial class SearchForm : Form {

        List<Academician> acList;
        List<Academician> filteredAcList;

        Thread dbThread;

        #region Styling GUI
        Font labelFont = new Font("Segoe UI", 12F);
        Padding labelPadding = new Padding(5, 2, 0, 0);
        Size buttonSize = new Size(200, 30);
        #endregion

        public SearchForm() {
            InitializeComponent();

            //int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            listPanel.Padding = new Padding(0, 0, 5, 0);

            acList = new List<Academician>();
            facultyCB.SelectedIndex = 0;
            departmentCB.SelectedIndex = 0;

            //StartDataThread(); // to use this method you should disable SearchForm_Load
        }

        #region Thread solution for data retrieving
        /// <summary>
        ///  This is first method we found for asynchronous data retrieve.
        ///  Data is retrieved in new thread. We had a problem when we try
        ///  to update GUI from new thread so we had to use Invoke method.
        /// </summary>
        private void StartDataThread() {
            //We are using new thread for database connection to make
            //our data load asynchronous from UI thread.
            dbThread = new Thread(delegate () {
                DbHelper db = new DbHelper();
                acList = db.GetAcademicians();
                filteredAcList = acList;
                AddRowsToPanel();

                this.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread again.
                    // Lets fadeout loading screen
                    ((MainForm)this.MdiParent).FadeOutLoading();
                });

                //Lets kill that thread after we retrieved data and updated form
                dbThread.Abort();

            });
            dbThread.Start();
        }

        /// <summary>
        /// This function will be called from data thread
        /// </summary>
        private void AddRowsToPanel()
        {

            foreach( Academician ac in acList) {
                FlatUI.FlatLabel profileLabel = new FlatUI.FlatLabel();
                profileLabel.Text = ac.Name + " - " + ac.Faculty + ", " + ac.Department;
                profileLabel.Tag = ac.Id;
                profileLabel.Font = labelFont;
                profileLabel.Margin = labelPadding;
                profileLabel.AutoSize = true;
                profileLabel.MouseEnter += ProfileLabel_MouseEnter;
                profileLabel.MouseLeave += ProfileLabel_MouseLeave;
                profileLabel.Click += Profile_Click;

                FlatUI.FlatButton profileButton = new FlatUI.FlatButton();
                profileButton.Text = "Özgeçmiş";
                profileButton.Tag = ac.Id;
                profileButton.Size = buttonSize;
                profileButton.Click += Profile_Click;

                FlatUI.FlatButton scheduleButton = new FlatUI.FlatButton();
                scheduleButton.Text = "Ders Programı";
                scheduleButton.Tag = ac.Id;
                scheduleButton.Size = buttonSize;
                scheduleButton.Click += Profile_Click;

                //We cant update UI from another thread. We have to be in UI thread.
                // We can achieve it by invoking an anonymous method.
                // See: https://stackoverflow.com/a/661662/7822421
                this.listPanel.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread again
                    this.listPanel.Controls.Add(profileLabel, 0, listPanel.RowCount - 1);
                    //this.listPanel.Controls.Add(depLabel, 1, listPanel.RowCount - 1);
                    this.listPanel.Controls.Add(profileButton, 1, listPanel.RowCount - 1);
                    this.listPanel.Controls.Add(scheduleButton, 2, listPanel.RowCount - 1);
                    this.listPanel.RowCount++;
                });
            }
        }
        #endregion

        #region await/async solution for data retrieving

        /// <summary>
        /// This method will be fired asynchronously after form loaded
        /// </summary>
        private async void SearchForm_Load(object sender, EventArgs e) {
            DbHelper db = new DbHelper();
            acList = await db.GetAcademiciansAsync();
            filteredAcList = acList;
            UpdateList();
            ((MainForm)this.MdiParent).FadeOutLoading();
        }
        #endregion

        private void ApplyFilters(object sender, EventArgs e) {
            string selectedFac = "", selectedDep = "", searchText = "";
            bool filterByFac = false;
            bool filterByDep = false;
            bool filterByText = false;

            if (facultyCB.SelectedIndex > 0) {
                selectedFac = facultyCB.SelectedItem.ToString();
                filterByFac = true;
            }

            if (departmentCB.SelectedIndex > 0) {
                selectedDep = departmentCB.SelectedItem.ToString();
                filterByDep = true;
            }

            if (searchBox.Text.Length > 0) {
                searchText = searchBox.Text.Trim().ToLower();
                filterByText = true;
            }

            filteredAcList = new List<Academician>();

            foreach (Academician ac in acList) {
                bool facFilterPassed = !filterByFac;
                bool depFilterPassed = !filterByDep;
                bool textFilterPassed = !filterByText;

                if (filterByFac && ac.Faculty == selectedFac) {
                    facFilterPassed = true;
                }

                if (filterByDep && ac.Department == selectedDep) {
                    depFilterPassed = true;
                }

                if (filterByText && ac.Name.ToLower().Contains(searchText)) {
                    textFilterPassed = true;
                }

                if(facFilterPassed && depFilterPassed && textFilterPassed) {
                    filteredAcList.Add(ac);
                }
            }

            UpdateList();
        }

        private void UpdateList() {

            listPanel.Controls.Clear();

            foreach (Academician ac in filteredAcList) {
                FlatUI.FlatLabel profileLabel = new FlatUI.FlatLabel();
                profileLabel.Text = ac.Name + " - " + ac.Faculty + ", " + ac.Department;
                profileLabel.Tag = ac.Id;
                profileLabel.Font = labelFont;
                profileLabel.Margin = labelPadding;
                profileLabel.AutoSize = true;
                profileLabel.MouseEnter += ProfileLabel_MouseEnter;
                profileLabel.MouseLeave += ProfileLabel_MouseLeave;
                profileLabel.Click += Profile_Click;

                FlatUI.FlatButton profileButton = new FlatUI.FlatButton();
                profileButton.Text = "Özgeçmiş";
                profileButton.Tag = ac.Id;
                profileButton.Size = buttonSize;
                profileButton.Click += Profile_Click;

                FlatUI.FlatButton scheduleButton = new FlatUI.FlatButton();
                scheduleButton.Text = "Ders Programı";
                scheduleButton.Tag = ac.Id;
                scheduleButton.Size = buttonSize;
                scheduleButton.Click += Profile_Click;

                listPanel.Controls.Add(profileLabel, 0, listPanel.RowCount - 1);
                listPanel.Controls.Add(profileButton, 1, listPanel.RowCount - 1);
                listPanel.Controls.Add(scheduleButton, 2, listPanel.RowCount - 1);
                listPanel.RowCount++;

                if (!facultyCB.Items.Contains(ac.Faculty))
                    facultyCB.Items.Add(ac.Faculty);

                if (!departmentCB.Items.Contains(ac.Department))
                    departmentCB.Items.Add(ac.Department);

            }
        }

        private void Profile_Click(object sender, EventArgs e) {
            Control ctr = (Control)sender;

            int id;
            bool parsed = int.TryParse(ctr.Tag.ToString(), out id);

            if (!parsed || id < 0)
                MessageBox.Show("Bir hata meydana geldi");
            else
            {
                if (ctr.Text == "Ders Programı")
                    ((MainForm)MdiParent).ShowScheduleForm(id);                
                else
                    ((MainForm)MdiParent).ShowProfileForm(id);
            }
        }

        #region Styling GUI
        private void ProfileLabel_MouseEnter(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.ForeColor = Program.GREEN;

        }
        private void ProfileLabel_MouseLeave(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.ForeColor = Color.White;
        }
        #endregion

    }
}
