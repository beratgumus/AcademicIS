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
        
        int Id;
        bool editButtonVisibility = false;
        bool deleteButtonVisibility = false;
        DataTable oldTable;

        public CourseScheduleForm(int id,bool isAdminLoggedIn)
        {
            this.Id = id;
            InitializeComponent();
            if (isAdminLoggedIn)
            {
                editButton.Visible = true;
                editButtonVisibility = true;
                saveButton.Visible = true;
                deleteButtonVisibility = true;
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

        public bool GetEditButtonVisibility()
        {
            return editButtonVisibility;
        }

        public bool GetDeleteButtonVisibility()
        {
            return deleteButtonVisibility;
        }

        public int GetAcademicianId()
        {
            return this.Id;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).menuSearch_Click(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            courseSchedule.EditMode = DataGridViewEditMode.EditOnKeystroke;
            courseSchedule.ReadOnly = false;
            oldTable = ToDataTable(courseSchedule);

            editButton.Visible = false;
            editButton.SendToBack();
            saveButton.Visible = true;
            saveButton.BringToFront();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            DataTable table = ToDataTable(courseSchedule);
            DbHelper db = new DbHelper();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    int day = j + 1;
                    int session = i + 1;
                    string newValue = table.Rows[i][j].ToString();
                    string oldValue = oldTable.Rows[i][j].ToString();

                    if (newValue == "" && oldValue !="")
                    {
                        db.DeleteAcademicianCourse(Id,day,session);
                    }
                                    
                    else if (oldValue == "" && newValue !="" )
                    {
                            db.InsertAcademicianCourse(Id, day, session,newValue);
                    }
                    else if(oldValue != "" && newValue != "" && oldValue != newValue)
                    {
                            db.UpdateAcademicianCourse(Id, day, session, newValue);
                    }
                    
                    
                }
            }

            MessageBox.Show("Değişiklikler başarıyla kaydedildi", "Başarılı");

            saveButton.Visible = false;
            saveButton.SendToBack();
            editButton.Visible = true;
            editButton.BringToFront();

        }

        private DataTable ToDataTable(DataGridView dataGridView)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn dataGridViewColumn in dataGridView.Columns)
            {
                if (dataGridViewColumn.Visible)
                {
                    dt.Columns.Add();
                }
            }
            var cell = new object[dataGridView.Columns.Count];
            foreach (DataGridViewRow dataGridViewRow in dataGridView.Rows)
            {
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    cell[i] = dataGridViewRow.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }
    }
}
