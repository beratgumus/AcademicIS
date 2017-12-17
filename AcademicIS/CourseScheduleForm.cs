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
        public CourseScheduleForm(int id)
        {
            InitializeComponent();

            Dictionary<int,string>  courseSession = new Dictionary<int, string>();
            courseSession.Add(0, "09:00 - 09:45");
            courseSession.Add(1, "10:00 - 10:45");
            courseSession.Add(2, "11:00 - 11:45");
            courseSession.Add(3, "12:00 - 12:45");
            courseSession.Add(4, "Öğle Arası");
            courseSession.Add(5, "13:30 - 14:15");
            courseSession.Add(6, "14:30 - 15:15");
            courseSession.Add(7, "15:30 - 16:15");
            courseSession.Add(8, "16:30 - 17:15");

            courseSchedule.RowCount = courseSession.Count;

            for (int i =0; i < courseSession.Count ; i++)
            {
                string value;
                //  courseSchedule.Rows.Add();
                courseSession.TryGetValue(i, out value);
                courseSchedule.Rows[i].HeaderCell.Value = value;
            }

            DbHelper db = new DbHelper();
            DataTable table = db.GetAcademicianSchedule(id);

            for (int i = 0; i < table.Rows.Count ; i++)
            {
                int day= int.Parse(table.Rows[i][1].ToString()) -1;
                int sessionNo = int.Parse(table.Rows[i][2].ToString()) -1;
                string courseName = table.Rows[i][3].ToString();

                courseSchedule.Rows[sessionNo].Cells[day].Value = courseName;
                courseSchedule.Rows[sessionNo].Cells[day].Style.BackColor = Color.Red;
            }
            
        }
    }
}
