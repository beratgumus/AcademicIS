using System;
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

        Thread dbThread;

        #region Styling GUI
        Color hoverColor = Color.FromArgb(35, 168, 109);
        Font labelFont = new Font("Segoe UI", 12F);
        Padding labelPadding = new Padding(20, 5, 0, 0);
        Size buttonSize = new Size(200, 30);
        #endregion

        public SearchForm() {
            InitializeComponent();
            DbHelper db = new DbHelper();
            acList = new List<Academician>();

            //We are using new thread for database connection to make
            //our data load asynchronous from UI thread.
            dbThread = new Thread(delegate () {
                acList = db.GetAcademicians();
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


        private void AddRowsToPanel()
        {
            System.Drawing.Font labelFont = new System.Drawing.Font("Segoe UI", 12F);

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

        private void Profile_Click(object sender, EventArgs e) {
            Control ctr = (Control)sender;

            int id;
            bool parsed = int.TryParse(ctr.Tag.ToString(), out id);

            if (!parsed || id < 0)
                MessageBox.Show("Bir hata meydana geldi");
            else
            {
                if (ctr.Text == "Özgeçmiş")
                    ((MainForm)MdiParent).ShowProfileForm(id);
                
                else
                    ((MainForm)MdiParent).ShowScheduleForm(id);
            }
        }



        #region Styling GUI
        private void ProfileLabel_MouseEnter(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.BorderStyle = BorderStyle.FixedSingle;
            lab.ForeColor = hoverColor;

        }
        private void ProfileLabel_MouseLeave(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.BorderStyle = BorderStyle.None;
            lab.ForeColor = Color.White;
        }
        #endregion

    }
}
