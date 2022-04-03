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

        /// <summary>
        /// Constructor of Data_Access Class
        /// Initialize all attribut required for ADO.NET
        /// </summary>
        public Data_Access()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
        }

        /// <summary>
        /// This oppen the database.
        /// </summary>
        public void link()
        {
            conn.ConnectionString = @"Data Source=ZENSHEIX\SQLEXPRESS;Initial Catalog=GradesManagement;Integrated Security=True";
            conn.Open();
        }

        /// <summary>
        /// This close the database.
        /// </summary>
        public void unLink()
        {
            conn.Close();
        }

        /// <summary>
        /// This allows to insert element in database
        /// </summary>
        /// <param name="table"></param>
        public void OpenIdentityInsert(string table)
        {
            string query = string.Format("SET IDENTITY_INSERT GradesManagement.dbo.{0} ON", table);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }

        /// <summary>
        /// This remove the permission of insert element in database
        /// </summary>
        /// <param name="table"></param>
        public void CloseIdentityInsert(string table)
        {
            string query = string.Format("SET IDENTITY_INSERT GradesManagement.dbo.{0} OFF", table);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }

        /// <summary>
        /// This select data
        /// </summary>
        /// <param name="selectColumn"></param>
        /// <param name="query"></param>
        /// <returns>This return a DataTable with the selected informations</returns>
        public DataTable SelectedData(string selectColumn, string query)
        {
            string strsql = string.Format("Select {0} from "+query, selectColumn);
            cmd.CommandText = strsql;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// This insert element in database
        /// </summary>
        /// <param name="table"></param>
        /// <param name="value"></param>
        public void insert(string table, string value)
        {
            string query = "INSERT INTO " + table + " VALUES " + value;
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }

        /// <summary>
        /// This search a specific elements
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns>return DataTable with element searched</returns>
        public DataTable find(string table, string column, int value)
        {
            string query = string.Format("SELECT {1} FROM {0} WHERE {1}={2}", table, column, value);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// This delete an element from the database.
        /// Delete when column = value
        /// </summary>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        public void delete(string table, string column, int value)
        {
            string query = string.Format("DELETE FROM {0} WHERE {1}={2}", table, column, value);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }

        /// <summary>
        /// This alows to modify database
        /// </summary>
        /// <param name="table"></param>
        /// <param name="values"></param>
        /// <param name="condition"></param>
        public void update(string table, string values, string condition)
        {
            string query = string.Format("UPDATE {0} SET {1} WHERE {2}", table, values, condition);
            cmd.CommandText = query;
            dt = new DataTable();
            da.Fill(dt);
        }
    }
}
