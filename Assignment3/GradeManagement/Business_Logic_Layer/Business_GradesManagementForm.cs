﻿using System;
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
        public string CoursName { get; set; }

        public Business_GradesManagementForm()
        {

        }
        public DataTable SelectAllStudent()
        {
            base.link();
            string Query = "Select * from Student";
            DataTable outPut = base.SelectedData(Query);
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
            string Query = "Select StudentId from Student";
            DataTable outPut = base.SelectedData(Query);
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
            string Query = "Select CoursName from Course";
            DataTable outPut = base.SelectedData(Query);
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
            string Query = string.Format("Select * from Student WHERE StudentId = {0}", this.StudentId);
            DataTable outPut = base.SelectedData(Query);
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
            string Query = string.Format("Select * from Course WHERE CoursName = '{0}'", this.CoursName);
            DataTable outPut = base.SelectedData(Query);
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
            string Query = string.Format("Select Grade from Grade WHERE StudentId = {0} AND CoursId = {1}", this.StudentId, this.CoursId);
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }
    }
}
