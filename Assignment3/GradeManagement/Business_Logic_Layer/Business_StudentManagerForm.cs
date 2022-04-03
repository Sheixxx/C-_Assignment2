using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Access_Layer;
using System.Data.SqlClient;

namespace Business_Logic_Layer
{
    public class Business_StudentManagerForm:Data_Access
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime BirthDate { get; set; }
        public Business_StudentManagerForm()
        {
            StudentId = -1;
            Name = "";
            Family = "";
            BirthDate = DateTime.Now;
        }
        public DataTable Select()
        {
            base.link();
            string Query = "Select * from Student";
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }
        public void Insertstudent()
        {
            base.link();
            string query = null;
            DataTable outPut = base.exist("StudentId", StudentId);
            //query = string.Format("INSERT INTO Student(StudentId, Name, Family, BirthDate)  VALUES({0},\'{1}\',\'{2}\',\'{3}\')", StudentId, Name, Family, BirthDate);

            //if (query != null && exist != 0)
            //{
            //    base.modification(query);
            //}
            base.unLink();


        }
    }
}
