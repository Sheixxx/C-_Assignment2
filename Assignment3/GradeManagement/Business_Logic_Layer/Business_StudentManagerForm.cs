using Data_Access_Layer;
using System;
using System.Data;

namespace Business_Logic_Layer
{
    /// <summary>
    /// Constructor with all the properties for 4 attributs:
    /// StudentId, Name, Family and BirthDate
    /// </summary>
    public class Business_StudentManagerForm : Data_Access
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
            DataTable outPut = base.SelectedData("*", Query);
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
            string Query = string.Format("Student WHERE StudentId = {0}", this.StudentId);
            DataTable outPut = base.SelectedData("*", Query);
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
            string values = string.Format("({0},\'{1}\',\'{2}\',\'{3}\')", StudentId, Name, Family, BirthDate);
            base.insert("Student(StudentId, Name, Family, BirthDate)", values);
            base.CloseIdentityInsert("Student");
            base.unLink();
        }
        /// <summary>
        /// This delete a student
        /// </summary>
        public void DeleteStudent()
        {
            base.link();
            base.delete("Student", "StudentId", StudentId);
            base.unLink();
        }

        /// <summary>
        /// This update information of a specific student using his id.
        /// </summary>
        public void UpdateStudent()
        {
            base.link();
            string values = string.Format("Name = '{0}', Family = '{1}', BirthDate = '{2}'", this.Name, this.Family, this.BirthDate);
            string condition = string.Format("StudentId = {0}", this.StudentId);
            base.update("Student", values, condition);
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
            else
            {
                base.unLink();
                return false;
            }
        }

        /// <summary>
        /// fill all class attributs with information of next student
        /// </summary>
        public void DisplayNextStudent()
        {
            base.link();
            DataTable table = base.SelectedData("*", String.Format("Student where StudentId > {0}", this.StudentId));
            try
            {
                this.FillInformations(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            base.unLink();
        }

        /// <summary>
        /// fill all class attributs with information of the one before student
        /// </summary>
        public void DisplayPrevStudent()
        {
            base.link();
            DataTable table = base.SelectedData("*", String.Format("Student where StudentId<{0} ORDER BY StudentId DESC", this.StudentId));
            try
            {
                this.FillInformations(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            base.unLink();
        }

        /// <summary>
        /// fill all class attributs with information of the first student
        /// </summary>
        public void DisplayFirstStudent()
        {
            base.link();
            DataTable table = base.SelectedData("*", String.Format("Student"));
            try
            {
                this.FillInformations(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            base.unLink();
        }

        /// <summary>
        /// fill all class attributs with information of the last student
        /// </summary>
        public void DisplayLastStudent()
        {
            base.link();
            DataTable table = base.SelectedData("*", String.Format("Student ORDER BY StudentId DESC"));
            try
            {
                this.FillInformations(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            base.unLink();
        }

        public void FillInformations(DataTable table)
        {
            this.StudentId = (int)table.Rows[0]["StudentId"];
            this.Name = table.Rows[0]["Name"].ToString().Trim();
            this.Family = table.Rows[0]["Family"].ToString().Trim();
            this.BirthDate = (DateTime)table.Rows[0]["BirthDate"];
        }

    }
}
