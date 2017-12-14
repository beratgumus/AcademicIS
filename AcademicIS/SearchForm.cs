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

            DataTable table = db.getAcademicians();
            addRowToPanel(table);
            //MessageBox.Show(" " + table.Rows[0][1]);
           
        }

        private void addRowToPanel(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {

                listPanel.Controls.Add(new FlatUI.FlatLabel { Text = table.Rows[i][1].ToString(),Font = new System.Drawing.Font("Segoe UI", 12F), Margin = new Padding(20,5,0,0) }, 0, listPanel.RowCount - 1);
                listPanel.Controls.Add(new FlatUI.FlatButton { Text = "Özgeçmiş", Size = new Size(200, 25) }, 1, listPanel.RowCount - 1);
                listPanel.Controls.Add(new FlatUI.FlatButton { Text = "Haftalık Program", Size = new Size(200, 25) },2, listPanel.RowCount - 1);
                RowStyle temp = listPanel.RowStyles[listPanel.RowCount - 1];
                listPanel.RowCount++;
                listPanel.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            }
        }
    }
}
