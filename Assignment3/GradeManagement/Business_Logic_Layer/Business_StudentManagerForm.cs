using System;
using System.Data;
using Data_Access_Layer;

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

        public DataTable SelectStudent()
        {
            base.link();
            string Query = string.Format("Select * from Student WHERE StudentId = {0}",this.StudentId);
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }
        public void Insertstudent()
        {
            base.link();
            base.OpenIdentityInsert("Student");
            if(! (base.exist("Student","StudentId", StudentId)))
            {
                string query = string.Format("INSERT INTO Student(StudentId, Name, Family, BirthDate)  VALUES({0},\'{1}\',\'{2}\',\'{3}\')", StudentId, Name, Family, BirthDate);
                base.modification(query);
            }
            else
            {
                // afficher message dans message box l'identifiant est deja utilisé
                Console.WriteLine("This student ID is already used!");
            }
            base.CloseIdentityInsert("Student");
            base.unLink();
        }
    }
}
