using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studentsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentManagerForm studentManagerForm = new StudentManagerForm();
            studentManagerForm.ShowDialog();
        }

        private void gradesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesManagementForm gradesManagementForm = new GradesManagementForm();
            gradesManagementForm.ShowDialog();
        }
    }
}
