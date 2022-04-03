using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Business_GradesManagementForm : Data_Access
    {
        public int StudentId { get; set; }
        public int CoursId { get; set; }
        public int Grade { get; set; }
        public string CoursName { get; set; }

        public Business_GradesManagementForm()
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
            DataTable outPut = base.SelectedData("*",Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Select all grades
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAllGrades()
        {
            base.link();
            string Query = "Grade";
            DataTable outPut = base.SelectedData("*", Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Get All student Ids from database
        /// </summary>
        /// <returns>Table containing all student Ids</returns>
        public DataTable SelectAllStudentId()
        {
            base.link();
            string Query = "Student";
            DataTable outPut = base.SelectedData("StudentId",Query);
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
            DataTable outPut = base.SelectedData("CoursName",Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Select student by Id using the variable StudentId
        /// </summary>
        /// <returns></returns>
        public DataTable SelectStudentByID()
        {
            base.link();
            string Query = string.Format("Student WHERE StudentId = {0}", this.StudentId);
            DataTable outPut = base.SelectedData("*",Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Select Couse by name
        /// </summary>
        /// <returns></returns>
        public DataTable SelectCourseByName()
        {
            base.link();
            string Query = string.Format("Course WHERE CoursName = '{0}'", this.CoursName);
            DataTable outPut = base.SelectedData("*", Query);
            base.unLink();
            return outPut;
        }
        /// <summary>
        /// Select Grade by id
        /// </summary>
        /// <returns></returns>
        public DataTable SelectGradeById()
        {
            base.link();
            string Query = string.Format("Grade WHERE StudentId = {0} AND CourseId = {1}", this.StudentId, this.CoursId);
            DataTable outPut = base.SelectedData("*", Query);
            base.unLink();
            return outPut;
        }

        /// <summary>
        /// Check if a student has a grade for this course
        /// </summary>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool gradeExist()
        {
            base.link();
            string Query = string.Format("Grade WHERE StudentId = {0} AND CourseId = {1}", this.StudentId, this.CoursId);
            DataTable outPut = base.SelectedData("*", Query);
            if (outPut != null && outPut.Rows.Count > 0)
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
        /// Insert one Grade.
        /// </summary>
        public void InsertGrade()
        {
            base.link();
            string values = string.Format("({0},{1},{2})", StudentId, CoursId, Grade);
            base.insert("Grade(StudentId, CourseId, Grade)", values);
            base.unLink();
        }

        /// <summary>
        /// Update Grade of student
        /// </summary>
        public void UpdateGrade()
        {
            base.link();
            string values = string.Format("Grade = {0}", this.Grade);
            string condition = string.Format("StudentId = {0} AND CourseId = {1}", this.StudentId, this.CoursId);
            base.update("Grade", values, condition);
            base.unLink();
        }
    }
}
