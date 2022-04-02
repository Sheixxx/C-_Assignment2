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
    public partial class StudentManagerForm : Form
    {
        Business_StudentManagerForm bf = new Business_StudentManagerForm();
     
        public StudentManagerForm()
        {
            InitializeComponent();
           
        }

        private void StudentManagerForm_Load(object sender, EventArgs e)
        {
        
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.textBoxFamily.Clear();
            this.textBoxName.Clear();
            this.textBoxID.Clear();
            this.dateTimePickerBirthDate.Value = DateTime.Today;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.textBoxID.Text);
            Console.WriteLine(this.textBoxFamily.Text);
            Console.WriteLine(this.textBoxName.Text);
            //this.bf.StudentId = Convert.ToInt32(this.textBoxID.Text);
            this.bf.Name = this.textBoxName.Text;
            this.bf.Family= this.textBoxFamily.Text;
            this.bf.BirthDate= this.dateTimePickerBirthDate.Value;

            bf.Insertstudent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
