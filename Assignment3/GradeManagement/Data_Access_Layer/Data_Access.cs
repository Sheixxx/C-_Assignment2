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
        }

        public void unLink()
        {
            conn.Close();
        }

        public DataTable SelectedData(string strsql)
        {
            cmd.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
