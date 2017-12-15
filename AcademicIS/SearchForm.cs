using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS {
    public partial class SearchForm : Form {
        public SearchForm() {
            InitializeComponent();
            DbHelper db = new DbHelper();

            DataTable table = db.GetAcademicians();
            addRowToPanel(table);
            //MessageBox.Show(" " + table.Rows[0][1]);
        }

        private void addRowToPanel(DataTable table)
        {
            System.Drawing.Font labelFont = new System.Drawing.Font("Segoe UI", 12F);
            Padding labelPadding = new Padding(20, 5, 0, 0);
            Size buttonSize = new Size(200, 30);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                FlatUI.FlatLabel nameLabel = new FlatUI.FlatLabel();
                nameLabel.Text = table.Rows[i][1].ToString();
                nameLabel.Font = labelFont;
                nameLabel.Margin = labelPadding;

                FlatUI.FlatButton profileButton = new FlatUI.FlatButton();
                profileButton.Text = "Özgeçmiş";
                profileButton.Tag = table.Rows[i][0];
                profileButton.Size = buttonSize;
                profileButton.Click += ProfileButton_Click;

                listPanel.Controls.Add(nameLabel, 0, i);
                listPanel.Controls.Add(profileButton, 1, i);
                listPanel.Controls.Add(new FlatUI.FlatButton { Text = "Haftalık Program", Size = new Size(200, 30) },2, i);
                //RowStyle temp = listPanel.RowStyles[listPanel.RowCount - 1];
                listPanel.RowCount++;
                //listPanel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
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
