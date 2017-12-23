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

            SqlCommand command = new SqlCommand(
                "SELECT A.*, F.Faculty_name, D.Department_name " +
                "FROM Academician as A, Faculty as F, Department as D "+
                "WHERE A.Id = @Id " +
                "AND A.Faculty_id = F.Id "+
                "AND A.Department_id = D.Id ", conn);

            command.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            
            conn.Open();
            adp.Fill(table);
            conn.Close();

            DataRow row = table.Rows[0]; // we will have only one row

            // Academician details are in RTF in database. However, when retrieving data,
            // something escapes every \ char to \\ . So some string like "{\\rtf1\\ansi"
            // is becoming "{\\\\rtf1\\\\ansi". Below line hotfixes that problem by simply
            // replacing it back. Maybe better solution?
            string rtf = row["Detail_info"].ToString().Replace("\\\\", "\\");

            Academician ac = new Academician(id, row["Name"].ToString(),
                row["Faculty_name"].ToString(), row["Department_name"].ToString(),
                row["Mail"].ToString(), row["Phone"].ToString(),
                row["Website"].ToString(), rtf);

            return ac;
        }

        /// <summary>
        /// Inserts given academician to database and returns its ID.
        /// Returns -1 if insertion fails.
        /// </summary>
        /// <param name="ac">Academician to insert</param>
        /// <returns>Inserted academicians id</returns>
        public int InsertAcademician(Academician ac) {

            try {
                string query = 
                    "INSERT INTO Academician " +
                    "OUTPUT INSERTED.ID " +
                    "VALUES(@Name, @FacId, @DepId, @Mail, @Phone, @Website, "+
                    "@DetailInfo )";

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", ac.Name);
                cmd.Parameters.AddWithValue("@FacId", ac.Faculty_id);
                cmd.Parameters.AddWithValue("@DepId", ac.Deparment_id);
                cmd.Parameters.AddWithValue("@Mail", ac.Mail);
                cmd.Parameters.AddWithValue("@Phone", ac.Phone);
                cmd.Parameters.AddWithValue("@Website", ac.Website);
                cmd.Parameters.AddWithValue("@DetailInfo", ac.Detail_RTF);

                Int32 insertedId = (Int32)cmd.ExecuteScalar();

                conn.Close();
                return insertedId;
            }
            catch (Exception e) {
                Console.WriteLine("An error ocurred when inserting new row. Message: " + e.Message);
                return -1;
            }
        }

        public DataTable GetAcademicianSchedule(int id)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM Courses " +
                "WHERE academician_id = @Id", conn);

            command.Parameters.AddWithValue("@Id", id);

            SqlDataAdapter adp = new SqlDataAdapter(command);
            conn.Open();
            adp.Fill(table);
            conn.Close();

            return table;
        }
        public void InsertAcademicianCourse(int Id, int day, int session, string newValue)
        {
            try
            {
                string query =
                    "INSERT INTO Courses " +
                    "VALUES(@academician_id, @Course_day, @Course_session, @Course_name )";

                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@academician_id", Id);
                cmd.Parameters.AddWithValue("@Course_day", day);
                cmd.Parameters.AddWithValue("@Course_session", session);
                cmd.Parameters.AddWithValue("@Course_name", newValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error ocurred when inserting new row. Message: " + e.Message);
            }
        }
        public Dictionary<FacDep, List<FacDep>> GetFacultyAndDepartments() {

            DataTable table = new DataTable();
            string query =
                "SELECT Faculty_id, Faculty_name, D.Id as Department_id, Department_name " +
                "FROM Faculty as F, Department as D " +
                "WHERE D.Faculty_id = F.Id";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);
            conn.Open();
            adp.Fill(table);
            conn.Close();

            Dictionary<FacDep, List<FacDep>> list = new Dictionary<FacDep, List<FacDep>>();

            foreach (DataRow row in table.Rows) {
                FacDep fac = new FacDep();
                fac.id = int.Parse(row["Faculty_id"].ToString());
                fac.name = row["Faculty_name"].ToString();

                FacDep dep = new FacDep();
                dep.id = int.Parse(row["Department_id"].ToString());
                dep.name = row["Department_name"].ToString();

                if (!list.ContainsKey(fac))
                    list.Add(fac, new List<FacDep>());

                list[fac].Add(dep);

            }

            return list;
        }
    }
}
