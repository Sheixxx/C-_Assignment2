using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class PatientManagementForm : Form
    {
        public PatientManagementForm()
        {
            InitializeComponent();
        }

        private void buttonNewPM_Click(object sender, EventArgs e)
        {
            textBoxCodePM.Text = "";
            textBoxNamePM.Text = "";
            textBoxAddressPM.Text = "";
            radioButtonFemininePM.Checked = false;
            radioButtonMasculinePM.Checked = false;
            dateTimePickerBirthDatePM.Value = DateTime.Now;
        }
    }
}
