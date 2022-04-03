using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class Data_Access
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Data_Access()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
        }

        public void link()
        {
            conn.ConnectionString = @"Data Source=ZENSHEIX\SQLEXPRESS;Initial Catalog=GradesManagement;Integrated Security=True";
            conn.Open();
            Console.WriteLine(conn.State.ToString());
        }

        public void unLink()
        {
            conn.Close();
            Console.WriteLine(conn.State.ToString());
        }

        public DataTable SelectedData(string strsql)
        {
            cmd.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable modification(string strsql)
        {
            Console.WriteLine("begin modification");
            
            cmd.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);

            Console.WriteLine("end modification");
            return dt;
        }

        public DataTable exist(string column, int value)
        {
            Console.WriteLine("begin exist");
            
            string query = string.Format("SELECT {0} FROM Student WHERE {0}={1}", column, value);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);

            Console.WriteLine("end exist");
            return dt;
        }
    }
}
