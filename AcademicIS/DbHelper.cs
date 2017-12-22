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
        SqlConnection conn;
        public DbHelper()
        {
             conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True;Connect Timeout=10");
        }

        public List<Academician> GetAcademicians()
        {
            DataTable table = new DataTable();
            string query = 
                "Select A.Id, Name, Faculty_name, Department_name " +
                "FROM Academician as A, Faculty as F, Department as D " +
                "WHERE A.Faculty_id = F.Id " +
                "AND A.Department_id = D.Id ";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            conn.Open();
            adp.Fill(table);
            conn.Close();

            List<Academician> acList = new List<Academician>();

            foreach (DataRow row in table.Rows) {

                int id = int.Parse(row[0].ToString());
                Academician acTemp = new Academician(id, row[1].ToString(),
                row[2].ToString(), row[3].ToString());

                acList.Add(acTemp);
            }

            return acList;
        }

        public Task<List<Academician>> GetAcademiciansAsync() {
            return Task.Run(() => {

                string query = 
                    "Select A.Id, Name, Faculty_name, Department_name " +
                    "FROM Academician as A, Faculty as F, Department as D " +
                    "WHERE A.Faculty_id = F.Id " +
                    "AND A.Department_id = D.Id ";
                using (SqlDataAdapter adp = new SqlDataAdapter(query, conn)) {

                    DataTable table = new DataTable();
                    conn.Open();
                    adp.Fill(table);
                    conn.Close();

                    List<Academician> acList = new List<Academician>();

                    foreach (DataRow row in table.Rows) {

                        int id = int.Parse(row[0].ToString());
                        Academician acTemp = new Academician(id, row[1].ToString(),
                        row[2].ToString(), row[3].ToString());

                        acList.Add(acTemp);
                    }

                    return acList;
                }
            });
        }

        public Academician GetAcademician(int id) {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Academician WHERE Id = " + id, conn);
            conn.Open();
            adp.Fill(table);
            conn.Close();

            DataRow row = table.Rows[0]; // we will have only one row

            // Academician details are in RTF in database. However, when retrieving data,
            // something escapes every \ char to \\ . So some string like "{\\rtf1\\ansi"
            // is becoming "{\\\\rtf1\\\\ansi". Below line hotfixes that problem by simply
            // replacing it back. Maybe better solution?
            string rtf = row[9].ToString().Replace("\\\\", "\\"); 

            Academician ac = new Academician(id, row[1].ToString(),
                row[2].ToString(), row[3].ToString(),row[4].ToString(),
                row[5].ToString(), row[6].ToString(),
                row[7].ToString(), rtf);

            return ac;
        }

        public DataTable GetAcademicianSchedule(int id)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Courses WHERE academician_id = " + id, conn);
            conn.Open();
            adp.Fill(table);
            conn.Close();

            return table;
        }

    }
}
