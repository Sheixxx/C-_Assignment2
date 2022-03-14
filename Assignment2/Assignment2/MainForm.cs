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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Exit ?",
                                     "Press \"Yes\" to confirm!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientManagementForm formPatient = new PatientManagementForm();
            formPatient.Show();
        }
        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorManagementForm formDoctor = new DoctorManagementForm();
            formDoctor.Show();
        }

        private void apointmentManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentManagement formAppointment = new AppointmentManagement();
            formAppointment.Show();
        }

        private void showAllPart1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll formShowAll = new ShowAll();
            formShowAll.Show();
        }

        private void searchAppointmentByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAppointment formSearchAppointment = new SearchAppointment();
            formSearchAppointment.Show();
        }

        private void showAPatientsAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPatientAppointments formShowPatientAppointments = new ShowPatientAppointments();
            formShowPatientAppointments.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
