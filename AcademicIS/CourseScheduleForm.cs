using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS
{
    public partial class CourseScheduleForm : Form
    {
        public CourseScheduleForm(int id,bool isAdminLoggedIn)
        {

            InitializeComponent();
            if (isAdminLoggedIn)
            {
                deleteButton.Visible = true;
                editButton.Visible = true;
            }
            Dictionary<int,string>  courseSession = new Dictionary<int, string>();
            courseSession.Add(0, "09:00 - 09:45");
            courseSession.Add(1, "10:00 - 10:45");
            courseSession.Add(2, "11:00 - 11:45");
            courseSession.Add(3, "12:00 - 12:45");
            courseSession.Add(4, "Ara");
            courseSession.Add(5, "13:30 - 14:15");
            courseSession.Add(6, "14:30 - 15:15");
            courseSession.Add(7, "15:30 - 16:15");
            courseSession.Add(8, "16:30 - 17:15");

            courseSchedule.RowCount = courseSession.Count;

            for (int i = 0; i < courseSession.Count ; i++)
            {
                string value;
                //  courseSchedule.Rows.Add();
                courseSession.TryGetValue(i, out value);
                courseSchedule.Rows[i].HeaderCell.Value = value;
            }
            courseSchedule.Rows[4].Height = 20;


            DbHelper db = new DbHelper();
            DataTable table = db.GetAcademicianSchedule(id);

            for (int i = 0; i < table.Rows.Count ; i++)
            {
                int day= int.Parse(table.Rows[i][1].ToString()) -1;
                int sessionNo = int.Parse(table.Rows[i][2].ToString()) -1;
                string courseName = table.Rows[i][3].ToString();

                DataGridViewCell currentCell = courseSchedule.Rows[sessionNo].Cells[day];
                currentCell.Value = courseName;
                if (courseName.ToLower().Contains("ofis"))
                    currentCell.Style.BackColor = Program.GREEN;
                else
                    currentCell.Style.BackColor = Program.RED;
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).menuSearch_Click(sender, e);
        }
    }
}
