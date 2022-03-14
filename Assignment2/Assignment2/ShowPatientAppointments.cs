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
    public partial class ShowPatientAppointments : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public ShowPatientAppointments()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int value = 0;
                if (int.TryParse(textBoxPatientCode.Text, out value))
                {
                    var info = (from x in db.Appointments where (x.PatientId == value) select x).ToList();
                    dataGridViewPA.DataSource = info;

                    var patientInfo = db.Patient.First(x => x.PatientId.Equals(textBoxPatientCode.Text));

                    textBoxName.Text = patientInfo.PatientName.Trim();
                    dateTimePickerBirthDate.Value = patientInfo.BirthDate.Value;
                    textBoxAddress.Text = patientInfo.PatientAddress;
                }
                else
                {
                    MessageBox.Show("Please enter a valid Patient Code");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxPatientCode.Clear();
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxACode.Clear();
                maskedTextBoxDCode.Text = "00:00";

                dateTimePickerBirthDate.Value = DateTime.Now;
                dateTimePickerADate.Value = DateTime.Now;
                
                comboBoxDCode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void dataGridViewPA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    DoctorManagementForm doctorForm = new DoctorManagementForm();
                    doctorForm.setDoctorId(Int32.Parse(dataGridViewPA.CurrentCell.Value.ToString()));
                    doctorForm.ShowDialog();

                }
                var docteurId = from x in db.Doctor select x.DoctorId;
                comboBoxDCode.DataSource = docteurId;

                textBoxACode.Text = dataGridViewPA.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePickerADate.Value = DateTime.Parse(dataGridViewPA.Rows[e.RowIndex].Cells[1].Value.ToString());
                maskedTextBoxDCode.Text = dataGridViewPA.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxDCode.SelectedIndex = comboBoxDCode.Items.IndexOf(dataGridViewPA.Rows[e.RowIndex].Cells[3].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Appointments newAppointment = new Appointments();

            try
            {
                newAppointment = db.Appointments.First(originApp => originApp.AppointmentCode.Equals(Convert.ToInt32(textBoxACode.Text)));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
            try
            {
                if (Int32.TryParse(comboBoxDCode.Text, out int codeDoctor) 
                    && Int32.TryParse(textBoxPatientCode.Text, out int codePatient)
                    && Int32.TryParse(textBoxACode.Text, out int codeAppointment))
                {
                    newAppointment.DoctorId = codeDoctor;
                    newAppointment.PatientId = codePatient;
                    newAppointment.AppointmentCode = codeAppointment;

                }
                else
                {
                    MessageBox.Show("The value in Patient Code or Doctor code is not a number. ");
                    return;
                }

                newAppointment.AppointmentDate = dateTimePickerADate.Value;
                TimeSpan timeAppointment;
                if (TimeSpan.TryParse(maskedTextBoxDCode.Text, out timeAppointment))
                {
                    newAppointment.AppointmentTime = timeAppointment;
                }
                else
                {
                    MessageBox.Show("Time is not valid");
                    return;
                }
                db.SubmitChanges();
                MessageBox.Show("New Appointment updated to the bdd");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            textBoxACode.Clear();
            maskedTextBoxDCode.Clear();
            buttonSearch_Click(sender,e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the current appontment ?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Appointments newAppointment = new Appointments();
                    newAppointment = db.Appointments.First(originApp => originApp.AppointmentCode.Equals(Convert.ToInt32(textBoxACode.Text)));
                    db.Appointments.DeleteOnSubmit(newAppointment);
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Delete Cancel");
            }
            buttonSearch_Click(sender, e);
        }

        private void textBoxPatientCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
