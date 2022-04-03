using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace GradeManagement
{
    public partial class StudentManagerForm : Form
    {
        Business_StudentManagerForm bf = new Business_StudentManagerForm();
     
        public StudentManagerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear all the graphical fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.textBoxFamily.Clear();
            this.textBoxName.Clear();
            this.textBoxID.Clear();
            this.dateTimePickerBirthDate.Value = DateTime.Today;
        }

        /// <summary>
        /// This try to add a student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(this.textBoxID.Text ==null || this.textBoxName.Text == null || this.textBoxFamily.Text == null)
            {
                return;
            }
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            this.bf.Name = this.textBoxName.Text.Trim();
            this.bf.Family= this.textBoxFamily.Text.Trim();
            this.bf.BirthDate= this.dateTimePickerBirthDate.Value;
            if (!(this.bf.exist("StudentId", this.bf.StudentId)))
            {

                try
                {
                    bf.Insertstudent();
                    MessageBox.Show("The student was inserted");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("This student id is already used");
            }
        }

        /// <summary>
        /// This close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This Search a student and fill all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            this.textBoxFamily.Clear();
            this.textBoxName.Clear();
            this.dateTimePickerBirthDate.Value = DateTime.Today;

            if (this.bf.exist("StudentId", this.bf.StudentId))
            {
                DataTable table = this.bf.SelectStudent();
                this.textBoxName.Text = table.Rows[0][1].ToString().Trim();
                this.textBoxFamily.Text = table.Rows[0][2].ToString().Trim();
                this.dateTimePickerBirthDate.Value = (System.DateTime)table.Rows[0][3];
            }
            else
            {
                MessageBox.Show("This student id not exist");
            }
        }

        /// <summary>
        /// This delete student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            if(this.bf.exist("StudentId",this.bf.StudentId))
            {
                this.bf.DeleteStudent();
                this.textBoxID.Clear();
                this.textBoxFamily.Clear();
                this.textBoxName.Clear();
                this.dateTimePickerBirthDate.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("This student id not exist");
            }
            
        }

        /// <summary>
        /// This modify a student information's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModify_Click(object sender, EventArgs e)
        {
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            if (this.bf.exist("StudentId", this.bf.StudentId))
            {
                this.fillFields();
                this.bf.UpdateStudent();
            }
            else
            {
                MessageBox.Show("This student id not exist");
            }
        }

        /// <summary>
        /// Put all information of the next student in fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            if (this.bf.exist("StudentId", this.bf.StudentId))
            {
                this.bf.DisplayNextStudent();
                this.fillFields();
            }
            else
            {
                MessageBox.Show("This student id not exist");
            }
        }

        /// <summary>
        /// Put all information of the one before student in fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPred_Click(object sender, EventArgs e)
        {
            this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            if (this.bf.exist("StudentId", this.bf.StudentId))
            {
                this.bf.DisplayPrevStudent();
                this.fillFields();
            }
            else
            {
                MessageBox.Show("This student id not exist");
            }
        }
        /// <summary>
        /// Put all information of the first student in fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPredPred_Click(object sender, EventArgs e)
        {
            this.bf.DisplayFirstStudent();
            this.fillFields();
        }

        /// <summary>
        /// Put all information of the last student in fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSuivSuiv_Click(object sender, EventArgs e)
        {
            this.bf.DisplayLastStudent();
            this.fillFields();
        }

        private void fillFields()
        {
            this.textBoxID.Text = this.bf.StudentId.ToString().Trim();
            this.textBoxName.Text = this.bf.Name.Trim();
            this.textBoxFamily.Text = this.bf.Family.Trim();
            this.dateTimePickerBirthDate.Value = this.bf.BirthDate;
        }
    }
}
