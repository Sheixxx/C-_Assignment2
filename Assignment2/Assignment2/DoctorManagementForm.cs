using System;
using System.Linq;
using System.Windows.Forms;


namespace Assignment2
{
    public partial class DoctorManagementForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DoctorManagementForm()
        {
            try
            {
                InitializeComponent();
                var specialty = (from x in db.Doctor select x.DoctorSpecialism).Distinct();
                comboBoxSpecialty.DataSource = specialty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
        }

        public bool inDataBase(int toTest)
        {
            if (db.Doctor.Any(t => t.DoctorId == toTest))
            {
                return true;
            }
            return false;
        }

        private void buttonNewDM_Click(object sender, EventArgs e)
        {
            textBoxCodeDM.Clear();
            textBoxNameDM.Clear();
            comboBoxSpecialty.SelectedIndex = 0;
            //textBoxTelephoneDM.Clear();
            maskedTextBoxTelephone.Clear();
            dateTimePickerHiringDateDM.Value = DateTime.Now;
            var specialty = (from x in db.Doctor select x.DoctorSpecialism).Distinct();
            comboBoxSpecialty.DataSource = specialty;
        }

        private void buttonSearchDM_Click(object sender, EventArgs e)
        {
            try
            {
                var doctorInfo = db.Doctor.First(x => x.DoctorId.Equals(textBoxCodeDM.Text));

                textBoxNameDM.Text = doctorInfo.DoctorName.Trim();
                maskedTextBoxTelephone.Text = doctorInfo.DoctorTel.ToString();
                dateTimePickerHiringDateDM.Value = doctorInfo.HiringDate.Value;
                comboBoxSpecialty.Text = doctorInfo.DoctorSpecialism.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
        }
        private void buttonAddDM_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            int var = 0;

            // We check that the input field are not empty
            if (textBoxCodeDM.Text == "")
            {
                MessageBox.Show("Code is empty");
            }
            else if (textBoxNameDM.Text == "")
            {
                MessageBox.Show("Name is empty");
            }
            else if (maskedTextBoxTelephone.Text == "")
            {
                MessageBox.Show("Telephone is empty");
            }
            else if (comboBoxSpecialty.Text == "")
            {
                MessageBox.Show("Specialty is empty");
            }
            else
            {
                // Check that the input value are correct
                if (int.TryParse(textBoxCodeDM.Text, out var))
                {
                    doctor.DoctorId = var;
                }
                else
                {
                    MessageBox.Show("Code Format is Invalid");
                }
                if (int.TryParse(maskedTextBoxTelephone.Text.Replace(" ", ""), out var))
                {
                    doctor.DoctorTel = var;
                }
                else
                {
                    MessageBox.Show("Telephone Format is Invalid");
                }
                doctor.DoctorName = textBoxNameDM.Text;
                doctor.DoctorSpecialism = comboBoxSpecialty.Text;
                doctor.HiringDate = dateTimePickerHiringDateDM.Value;


                db.Doctor.InsertOnSubmit(doctor);

                try
                {

                    db.SubmitChanges();
                    buttonNewDM_Click(sender,e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Message: " + ex.Message);
                }
            }
        }

        private void buttonEditDM_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            int var = 0;

            // We check that a Doctor has been loaded and that no field are empty
            if (textBoxCodeDM.Text == "")
            {
                MessageBox.Show("Code is empty");
            }
            else if (textBoxNameDM.Text == "")
            {
                MessageBox.Show("Name is empty");
            }
            else if (maskedTextBoxTelephone.Text == "")
            {
                MessageBox.Show("Telephone is empty");
            }
            else if (comboBoxSpecialty.Text == "")
            {
                MessageBox.Show("Specialty is empty");
            }
            else
            {
                doctor = db.Doctor.First(originDoctor => originDoctor.DoctorId.Equals(Convert.ToInt32(textBoxCodeDM.Text)));
                // Check that the input value are correct
                if (int.TryParse(textBoxCodeDM.Text, out var))
                {
                    doctor.DoctorId = var;
                }
                else
                {
                    MessageBox.Show("Code Format is Invalid");
                    
                }
                if (Int32.TryParse(maskedTextBoxTelephone.Text.Replace(" ", ""), out var))
                {
                    doctor.DoctorTel = var;
                }
                else
                {
                    MessageBox.Show("Telephone Format is Invalid");
                }
                doctor.DoctorName = textBoxNameDM.Text;
                doctor.DoctorSpecialism = comboBoxSpecialty.Text;
                doctor.HiringDate = dateTimePickerHiringDateDM.Value;

                try
                {
                    if (inDataBase(Convert.ToInt32(textBoxCodeDM.Text)))
                    {
                        db.SubmitChanges();

                        var specialty = (from x in db.Doctor select x.DoctorSpecialism).Distinct();
                        comboBoxSpecialty.DataSource = specialty;
                    }
                    else
                    {
                        MessageBox.Show("Id does not exist in the db");
                    }
                    
                    buttonNewDM_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception Message: " + ex.Message);
                }
            }
        }

        private void buttonDeleteDM_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("This Doctor will be deleted from the database ! ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (answer == DialogResult.OK)
            {
                Doctor doctor = new Doctor();
                doctor = db.Doctor.First(originDoctor => originDoctor.DoctorId.Equals(Convert.ToInt32(textBoxCodeDM.Text)));
                db.Doctor.DeleteOnSubmit(doctor);
                try
                {
                    db.SubmitChanges();
                    var specialty = (from x in db.Doctor select x.DoctorSpecialism).Distinct();
                    comboBoxSpecialty.DataSource = specialty;
                    MessageBox.Show("The patient has been deleted !");
                    buttonNewDM_Click(sender, e);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    buttonNewDM_Click(sender, e);
                }
            }
        }
        private void maskedTextBoxTelephone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("This phone number is invalid");
        }

        private void buttonExitDM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setDoctorId(int i)
        {
            textBoxCodeDM.Text = i.ToString();
            try
            {
                var doctorInfo = db.Doctor.First(x => x.DoctorId.Equals(textBoxCodeDM.Text));

                textBoxNameDM.Text = doctorInfo.DoctorName.Trim();
                maskedTextBoxTelephone.Text = doctorInfo.DoctorTel.ToString();
                dateTimePickerHiringDateDM.Value = doctorInfo.HiringDate.Value;
                comboBoxSpecialty.Text = doctorInfo.DoctorSpecialism.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
            }
        }
    }
}
