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
    public partial class AppointmentManagement : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public AppointmentManagement()
        {
            InitializeComponent();
            var docteurId = from x in db.Doctor select x.DoctorId;
            comboBoxDoctorCode.DataSource = docteurId;
            
            var patientId = from x in db.Patient select x.PatientId;
            comboBoxPatientCode.DataSource = patientId;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBoxPatientCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var patientInfo = db.Patient.First(x => x.PatientId.Equals(comboBoxPatientCode.SelectedItem));

            textBoxPatientName.Text = patientInfo.PatientName.Trim();
            if(patientInfo.PatientGender.Trim() == "M")
            {
                radioButtonMale.Checked = true;
            }
            else if (patientInfo.PatientGender.Trim() == "F")
            {
                radioButtonFemale.Checked = true;
            }

        }

        private void comboBoxDoctorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doctorInfo = db.Doctor.First(x => x.DoctorId.Equals(comboBoxDoctorCode.SelectedItem));

            textBoxDoctorName.Text = doctorInfo.DoctorName.Trim();
            textBoxDoctorSpeciality.Text = doctorInfo.DoctorSpecialism.Trim();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxDoctorName.Clear();
            textBoxDoctorSpeciality.Clear();
            textBoxPatientName.Clear();
            radioButtonFemale.Checked=false;
            radioButtonMale.Checked=false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string message = "Are you shure you want to exit appointment Form ?";
            string caption = "Appointment Form Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
