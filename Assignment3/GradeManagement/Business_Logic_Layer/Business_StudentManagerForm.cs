using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    /// <summary>
    /// Constructor with all the properties for 4 attributs:
    /// StudentId, Name, Family and BirthDate
    /// </summary>
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
        /// <summary>
        /// This Select all the students
        /// </summary>
        /// <returns>Return a DataTable with all elements in Student Table</returns>
        public DataTable Select()
        {
            base.link();
            string Query = "Select * from Student";
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// This select one precise student.
        /// </summary>
        /// <returns>Return a DataTable with the maximum of one element</returns>
        public DataTable SelectStudent()
        {
            base.link();
            string Query = string.Format("Select * from Student WHERE StudentId = {0}",this.StudentId);
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// This insert one student.
        /// </summary>
        /// <exception cref="SqlException">Exception if the studentId is already used.</exception>
        public void Insertstudent()
        {
            base.link();
            base.OpenIdentityInsert("Student");
            if(! (base.exist("Student","StudentId", StudentId)))
            {
                string query = string.Format("INSERT INTO Student(StudentId, Name, Family, BirthDate)  VALUES({0},\'{1}\',\'{2}\',\'{3}\')", StudentId, Name, Family, BirthDate);
                base.insert(query);
            }
            else
            {
                // afficher message dans message box l'identifiant est deja utilisé
                Console.WriteLine("This student ID is already used!");
            }
            base.CloseIdentityInsert("Student");
            base.unLink();
        }
        /// <summary>
        /// This delete a student
        /// </summary>
        public void DeleteStudent()
        {
            base.link();
            if (base.exist("Student", "StudentId", StudentId))
            {
                base.delete("Student", "StudentId",StudentId);
            }
            else
            {
                // afficher message dans message box l'identifiant est deja utilisé
                Console.WriteLine("This student ID not exist!");
            }
            base.unLink();
        }
    }
}
