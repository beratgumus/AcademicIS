using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS
{
    public class DbHelper
    {
        SqlConnection con;
        public DbHelper()
        {
             con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True;Connect Timeout=10");
        }

        public List<Academician> GetAcademicians()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select Id, Name, Faculty, Department from Academician", con);
            con.Open();
            adp.Fill(table);
            con.Close();

            List<Academician> acList = new List<Academician>();

            foreach (DataRow row in table.Rows) {

                int id = int.Parse(row[0].ToString());
                Academician acTemp = new Academician(id, row[1].ToString(),
                row[2].ToString(), row[3].ToString());

                acList.Add(acTemp);
            }

            return acList;
        }

        public Academician GetAcademician(int id) {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Academician WHERE Id = " + id, con);
            con.Open();
            adp.Fill(table);
            con.Close();

            DataRow row = table.Rows[0]; // we will have only one row

            Academician ac = new Academician(id, row[1].ToString(),
                row[2].ToString(), row[3].ToString(),row[4].ToString(),
                row[5].ToString(), row[6].ToString(), row[7].ToString(),
                row[8].ToString(), row[9].ToString());

            return ac;
        }

        public DataTable GetAcademicianSchedule(int id)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Courses WHERE academician_id = " + id, con);
            con.Open();
            adp.Fill(table);
            con.Close();

            return table;
        }

    }
}
