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
            init();
        }

        public void init()
        {
            try
            {
                var docteurId = from x in db.Doctor select x.DoctorId;
                comboBoxDoctorCode.DataSource = docteurId;

                var patientId = from x in db.Patient select x.PatientId;
                comboBoxPatientCode.DataSource = patientId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
            Console.WriteLine("date :" + dateTimePicker1.Text);
            Console.WriteLine("time :" + maskedTextBoxAppointmentTime.Text);

            Appointments newAppointment;
            newAppointment = new Appointments();
            if (Int32.TryParse(comboBoxDoctorCode.Text, out int codeDoctor) && Int32.TryParse(comboBoxPatientCode.Text, out int codePatient))
            {
                newAppointment.DoctorId = codeDoctor;
                newAppointment.PatientId = codePatient;
            }
            else
            {
                MessageBox.Show("The value in Patient Code or Doctor code is not a number. ");
                return;
            }

            if(dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("The selected date is not today or futur day.");
                return;
            }
            else
            {
                newAppointment.AppointmentDate = dateTimePicker1.Value;
            }

            TimeSpan timeAppointment;
            if (TimeSpan.TryParse(maskedTextBoxAppointmentTime.Text, out timeAppointment))
            {
                newAppointment.AppointmentTime = timeAppointment;
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Time is not valid");
                return;
            }

            db.Appointments.InsertOnSubmit(newAppointment);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("New Appointment added to the DB !");
                init();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return;
            }

        }

        private void comboBoxPatientCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
                var patientInfo = db.Patient.First(x => x.PatientId.Equals(comboBoxPatientCode.SelectedItem));
                textBoxPatientName.Text = patientInfo.PatientName.Trim();
                if (patientInfo.PatientGender.Trim() == "M")
                {
                    radioButtonMale.Checked = true;
                }
                else if (patientInfo.PatientGender.Trim() == "F")
                {
                    radioButtonFemale.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboBoxDoctorCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var doctorInfo = db.Doctor.First(x => x.DoctorId.Equals(comboBoxDoctorCode.SelectedItem));

                textBoxDoctorName.Text = doctorInfo.DoctorName.Trim();
                textBoxDoctorSpeciality.Text = doctorInfo.DoctorSpecialism.Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxDoctorName.Clear();
            textBoxDoctorSpeciality.Clear();
            textBoxPatientName.Clear();
            radioButtonFemale.Checked=false;
            radioButtonMale.Checked=false;
            dateTimePicker1.Value = DateTime.Today;
            maskedTextBoxAppointmentTime.Clear();
            init();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string message = "Are you shure you want to exit Appointment Management ?";
            string caption = "Appointment Form Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void maskedTextBoxAppointmentTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
