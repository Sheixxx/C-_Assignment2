using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Business_StudentManagerForm:Data_Access
    {
        //public int StudentId;
        public string Name;
        public string Family;
        public DateTime BirthDate;
        public Business_StudentManagerForm()
        {
            //StudentId = -1;
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
            //string query = "Insert into Student values (@p1,@p2,@p3,@p4)";
            //base.InsertedStudent(query, 10, "toto", "family", DateTime.Today);

            

            //string query = "Insert into Student values ({0},{1},{2})";
            string query = string.Format("Insert into Student values ({0},{1},{2})", Name, Family, BirthDate);
            base.modification(query);
            base.unLink();

        }
    }
}
