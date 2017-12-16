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

        public DataTable GetAcademicians()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select Id, Name from Academician", con);
            con.Open();
            adp.Fill(table);
            con.Close();
            return table;
        }

        public Academician GetAcademician(int id) {
            DataTable table = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Academician WHERE Id = " + id, con);
            con.Open();
            adp.Fill(table);
            con.Close();

            Academician ac = new Academician(id, table.Rows[0][1].ToString(), 
                table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), 
                table.Rows[0][4].ToString(), table.Rows[0][5].ToString(),
                table.Rows[0][6].ToString(), table.Rows[0][7].ToString(),
                table.Rows[0][8].ToString(), table.Rows[0][9].ToString());
            return ac;
            //return table.Rows[0];
        }
    }
}
