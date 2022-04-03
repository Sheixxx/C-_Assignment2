using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Business_ConsultationForm : Data_Access
    {
        public int StudentId { get; set; }
        public string StudentLastName { get; set; }

        public string StudentFirstName { get; set; }

        public int CoursId { get; set; }
        public int Grade { get; set; }
        public string CoursName { get; set; }


        public Business_ConsultationForm()
        {

        }

        /// <summary>
        /// Get all students infos
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllStudent()
        {
            base.link();
            string Query = "Student";
            DataTable outPut = base.SelectedData("*", Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Get All Course Ids from database
        /// </summary>
        /// <returns>Table containing all courses Ids</returns>
        public DataTable SelectAllCourseName()
        {
            base.link();
            string Query = "Course";
            DataTable outPut = base.SelectedData("CoursName", Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Select Couse by name
        /// </summary>
        /// <returns>Table containing all courses</returns>
        public DataTable SelectCourseByName()
        {
            base.link();
            string Query = string.Format("Course WHERE CoursName = '{0}'", this.CoursName);
            DataTable outPut = base.SelectedData("*", Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Select student information
        /// </summary>
        /// <returns>Table containing all student information</returns>
        public DataTable SelectStudentByCourseId()
        {
            base.link();
            string Query = string.Format(" Student, Grade WHERE Student.StudentId = Grade.StudentId AND Grade.CourseId = {0}", this.CoursId);
            DataTable output = base.SelectedData("Student.Name, Student.Family, Grade.Grade", Query);
            base.unLink();
            return output;
        }

        public DataTable Select()
        {
            base.link();
            string Query = "Student";
            DataTable outPut = base.SelectedData("*",Query);
            base.unLink();
            return outPut;
        }
    }
}
