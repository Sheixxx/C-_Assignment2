using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace GradeManagement
{
    public partial class GradesManagementForm : Form
    {
        Business_GradesManagementForm bf = new Business_Logic_Layer.Business_GradesManagementForm();
        public GradesManagementForm()
        {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// When the form starts, the "Student ID" and "Courses Name" lists will be loaded.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void Initialize()
        {
            this.comboBoxID.DataSource = bf.SelectAllStudent();
            comboBoxID.DisplayMember = "StudentId";
            this.comboBoxCourse.DataSource = bf.SelectAllCourseName();
            comboBoxCourse.DisplayMember = "CoursName";
        }
        /// <summary>
        /// When choosing a student's ID, his or her first and last name are displayed.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (Int32.TryParse(comboBoxID.Text, out int a))
                {
                    id = Int32.Parse(comboBoxID.Text);
                }
                string name = "";
                bf.StudentId = id;
                DataTable table = bf.SelectStudentByID();
                foreach (DataRow row in table.Rows)
                {
                    name = row["Name"].ToString().Trim() + " " + row["Family"].ToString().Trim();
                }
                
                textBoxNameFamily.Text = name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        /// <summary>
        /// When choosing a course, the grade of the student should be loaded 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 1- We get the name of the selected Course
                string name = " ";
                if (comboBoxCourse.Text.Length > 0)
                    name = comboBoxCourse.Text;
                bf.CoursName = name;
                // 2- We get the Id of the selected Course
                DataTable table = bf.SelectCourseByName();
                int id = 0;
                foreach (DataRow row in table.Rows)
                {
                    id = Int32.Parse(row["CoursId"].ToString());
                }
                bf.CoursId = id;
                
                int StudentId = 0;
                if (Int32.TryParse(comboBoxID.Text, out int a))
                {
                    StudentId = Int32.Parse(comboBoxID.Text);
                }
                bf.StudentId = StudentId;
                
                // 3- We get the grade of the selected Course and Selected Student
                int grade = 0;
                table = bf.SelectGradeById();
                foreach (DataRow row in table.Rows)
                {
                    grade = Int32.Parse(row["Grade"].ToString());
                }


                if(bf.gradeExist())
                {
                    textBoxGrade.Text = grade.ToString();
                }
                else
                {
                    textBoxGrade.Text = "No Grade";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The New button is used to empty all fields on the form.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.textBoxNameFamily.Clear();
            this.textBoxGrade.Clear();
            this.comboBoxID.SelectedIndex = 0;
            this.comboBoxCourse.SelectedIndex = 0;
        }

        /// <summary>
        /// This button allows you to save a student's grade in a course by checking 
        /// the constraint of filling in all fields and the uniqueness 
        /// and existence of the grade.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (!bf.gradeExist() || textBoxGrade.Text == "No Grade")
                {
                    string name = " ";
                    if (comboBoxCourse.Text.Length > 0)
                        name = comboBoxCourse.Text;
                    bf.CoursName = name;
                    DataTable table = bf.SelectCourseByName();
                    int id = 0;
                    foreach (DataRow row in table.Rows)
                        id = Int32.Parse(row["CoursId"].ToString());
                    bf.CoursId = id;
                    int StudentId = 0;
                    if (Int32.TryParse(comboBoxID.Text, out int a))
                        StudentId = Int32.Parse(comboBoxID.Text);
                    bf.StudentId = StudentId;

                    bf.Grade = Int32.Parse(textBoxGrade.Text);
                    bf.InsertGrade();
                }
                else
                    MessageBox.Show("This student already has a grade for the course");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// This button allows you to modify the grade of a student 
        /// loaded in a selected course.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void buttonModifyGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (bf.gradeExist() && textBoxGrade.Text != "No Grade")
                {
                    string name = " ";
                    if (comboBoxCourse.Text.Length > 0)
                        name = comboBoxCourse.Text;
                    bf.CoursName = name;
                    DataTable table = bf.SelectCourseByName();
                    int id = 0;
                    foreach (DataRow row in table.Rows)
                        id = Int32.Parse(row["CoursId"].ToString());
                    bf.CoursId = id;
                    int StudentId = 0;
                    if (Int32.TryParse(comboBoxID.Text, out int a))
                        StudentId = Int32.Parse(comboBoxID.Text);
                    bf.StudentId = StudentId;

                    bf.Grade = Int32.Parse(textBoxGrade.Text);
                    bf.UpdateGrade();
                }
                else
                    MessageBox.Show("This student already has a grade for the course");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The "Preview" button displays a grid containing the grades of the loaded student.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            DataTable toto = bf.SelectAllGrades();
            dataGridView1.DataSource = toto;
        }

        /// <summary>
        /// The Exit button closes the form.
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
