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

        public void OpenIdentityInsert(string table)
        {
            string query = string.Format("SET IDENTITY_INSERT GradesManagement.dbo.{0} ON", table);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }

        public void CloseIdentityInsert(string table)
        {
            string query = string.Format("SET IDENTITY_INSERT GradesManagement.dbo.{0} OFF", table);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
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
            cmd.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool exist(string column, int value)
        {
            string query = string.Format("SELECT {0} FROM Student WHERE {0}={1}", column, value);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
