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
             con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public DataTable getAcademicians()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Academician", con);
            con.Open();
            adp.Fill(table);
            con.Close();
            return table;
        }
    }
}
