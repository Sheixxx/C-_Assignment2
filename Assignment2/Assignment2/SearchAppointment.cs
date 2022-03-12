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
    public partial class SearchAppointment : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public SearchAppointment()
        {
            InitializeComponent();
            //dateTimePickerSelection.CustomFormat = "dd MMMM yyyy";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            try
            {
                var dataAppointment = (from x in db.Appointments
                                       where x.AppointmentDate == dateTimePickerSelection.Value
                                       select new
                                       {
                                           Data = x.AppointmentDate.ToString(),
                                           Time = x.AppointmentTime,
                                           Doctor = x.DoctorId,
                                           Patient = x.PatientId
                                       }).ToList();

                dataGridView1.DataSource = dataAppointment;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return;
            }


            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dateTimePickerSelection.Value = DateTime.Today;
            dataGridView1.DataSource = null;
            textBoxDoctorName.Clear();
            textBoxDoctorSpeciality.Clear();
            textBoxPatientName.Clear();
            dateTimePickerPatientBirthday.Value = DateTime.Today;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                var doctorId = selectedRow.Cells[2].Value;
                var patientId = selectedRow.Cells[3].Value;

                try
                {
                    var dataDoctor = db.Doctor.First(x => x.DoctorId.Equals(doctorId));
                    textBoxDoctorName.Text = dataDoctor.DoctorName.Trim();
                    textBoxDoctorSpeciality.Text = dataDoctor.DoctorSpecialism.Trim();

                    var dataPatient = db.Patient.First(x => x.PatientId.Equals(patientId));
                    textBoxPatientName.Text = dataPatient.PatientName.Trim();
                    dateTimePickerPatientBirthday.Value = dataPatient.BirthDate.Value;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    return;
                }
            }
        }
    }
}
