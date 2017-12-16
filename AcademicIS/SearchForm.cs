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

        public SearchForm() {
            InitializeComponent();
            DbHelper db = new DbHelper();
            acList = new List<Academician>();

            //We are using new thread for database connection to make
            //our data load asynchronous from UI thread.
            Thread dbThread = new Thread(delegate () {
                acList = db.GetAcademicians();
                AddRowsToPanel();

                this.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread again.
                    // Lets fadeout loading screen
                    ((MainForm)this.MdiParent).FadeOutLoading();
                });

            });
            dbThread.Start();


        }


        private void AddRowsToPanel()
        {
            System.Drawing.Font labelFont = new System.Drawing.Font("Segoe UI", 12F);
            Padding labelPadding = new Padding(20, 5, 0, 0);
            Size buttonSize = new Size(200, 30);

            foreach( Academician ac in acList) {
                FlatUI.FlatLabel nameLabel = new FlatUI.FlatLabel();
                nameLabel.Text = ac.Name;
                nameLabel.Font = labelFont;
                nameLabel.Margin = labelPadding;

                FlatUI.FlatButton profileButton = new FlatUI.FlatButton();
                profileButton.Text = "Özgeçmiş";
                profileButton.Tag = ac.Id;
                profileButton.Size = buttonSize;
                profileButton.Click += ProfileButton_Click;

                //We cant update UI from another thread. We have to be in UI thread.
                // We can achieve it by invoking an anonymous method.
                // See: https://stackoverflow.com/a/661662/7822421
                this.listPanel.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread again
                    this.listPanel.Controls.Add(nameLabel, 0, listPanel.RowCount - 1);
                    this.listPanel.Controls.Add(profileButton, 1, listPanel.RowCount - 1);
                    this.listPanel.Controls.Add(new FlatUI.FlatButton { Text = "Haftalık Program", Size = new Size(200, 30) }, 2, listPanel.RowCount - 1);
                    this.listPanel.RowCount++;
                });
            }

            

        }

        private void ProfileButton_Click(object sender, EventArgs e) {
            FlatUI.FlatButton btn = (FlatUI.FlatButton)sender;
            //MessageBox.Show(btn.Tag.ToString());
            int id;
            bool parsed = int.TryParse(btn.Tag.ToString(), out id);

            if (!parsed || id < 0)
                MessageBox.Show("Bir hata meydana geldi");
            else
                ((MainForm)MdiParent).ShowProfileForm(id);

        }

    }
}
