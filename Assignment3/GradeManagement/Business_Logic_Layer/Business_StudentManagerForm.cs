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
            string Query = "Student";
            DataTable outPut = base.SelectedData("*",Query);
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
            string Query = string.Format("Student WHERE StudentId = {0}",this.StudentId);
            DataTable outPut = base.SelectedData("*",Query);
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
            string query = string.Format("INSERT INTO Student(StudentId, Name, Family, BirthDate)  VALUES({0},\'{1}\',\'{2}\',\'{3}\')", StudentId, Name, Family, BirthDate);
            base.insert(query);
            base.CloseIdentityInsert("Student");
            base.unLink();
        }
        /// <summary>
        /// This delete a student
        /// </summary>
        public void DeleteStudent()
        {
            base.link();
            base.delete("Student", "StudentId",StudentId);
            base.unLink();
        }

        /// <summary>
        /// Search if an element exist or not
        /// </summary>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns>Return true if element exist</returns>
        public bool exist(string column, int value)
        {
            base.link();
            DataTable dt = base.find("Student", column, value);
            if (dt != null && dt.Rows.Count > 0)
            {
                base.unLink();
                return true;
            }
            else {
                base.unLink();
                return false;
            }
            
        }
    }
}
