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
    public partial class ConsultationForm : Form
    {

        Business_ConsultationForm bf = new Business_Logic_Layer.Business_ConsultationForm();

        public ConsultationForm()
        {
            InitializeComponent();
            this.comboBoxCourse.DataSource = bf.SelectAllCourseName();
            comboBoxCourse.DisplayMember = "CoursName";
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

                // 3-We fetch all the students information and grades
                DataTable table2 = bf.SelectStudentByCourseId();

                dataGridView1.DataSource = table2;

                // 4- We calculate the grade average
                int somme = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    somme += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                   
                }
                if (table2.Rows.Count > 0)
                {
                    double average = somme / (dataGridView1.Rows.Count - 1);
                    textBoxAverageClass.Text = average.ToString();
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
