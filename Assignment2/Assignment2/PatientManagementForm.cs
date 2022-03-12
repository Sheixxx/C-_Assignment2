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
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        public PatientManagementForm()
        {
            InitializeComponent();
        }

        public bool inDataBase (int toTest)
        {
            if (db.Patient.Any(t => t.PatientId == toTest))
            {
                return true;
            }
            return false;
        }

        public void resetData()
        {
            textBoxCodePM.Text = "";
            textBoxNamePM.Text = "";
            textBoxAddressPM.Text = "";
            radioButtonFemininePM.Checked = false;
            radioButtonMasculinePM.Checked = false;
            dateTimePickerBirthDatePM.Value = DateTime.Now;
        }

        private void buttonNewPM_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void buttonSearchPM_Click(object sender, EventArgs e)
        {
            int patientCode;

            if (textBoxCodePM.Text.Length == 0)
            {
                MessageBox.Show("Please fill in a code");
            } else
            {
                patientCode = Convert.ToInt32(textBoxCodePM.Text);

                if (!inDataBase(patientCode)){
                    /*throw new ArgumentException("L'identifiant ne correspond à aucun patient");*/
                    MessageBox.Show("L'identifiant ne correspond à aucun patient");
                }
                else
                {
                    var patientInfo = db.Patient.First(x => x.PatientId.Equals(patientCode));

                    textBoxNamePM.Text = patientInfo.PatientName.Trim();

                    dateTimePickerBirthDatePM.Value = patientInfo.BirthDate.Value;

                    textBoxAddressPM.Text = patientInfo.PatientAddress.Trim();

                    if (patientInfo.PatientGender.Trim() == "M")
                    {
                        radioButtonMasculinePM.Checked = true;
                    }
                    else if (patientInfo.PatientGender.Trim() == "F")
                    {
                        radioButtonFemininePM.Checked = true;
                    }
                }
                

            }

        }

        private void buttonAddPM_Click(object sender, EventArgs e)
        {
            Patient newPatient;

            if (textBoxCodePM.Text.Length == 0 || textBoxNamePM.Text.Length == 0 || (radioButtonFemininePM.Checked == false && radioButtonMasculinePM.Checked == false))
            {
                MessageBox.Show("Fill in all fields to add a new Patient");
            }
            else if (inDataBase(Convert.ToInt32(textBoxCodePM.Text)))
            {
                MessageBox.Show("This code is already assigned to a patient");
            }
            else
            {
                
                newPatient = new Patient();
                newPatient.PatientId = Convert.ToInt32(textBoxCodePM.Text);
                newPatient.PatientName = textBoxNamePM.Text;
                newPatient.BirthDate = dateTimePickerBirthDatePM.Value;
                newPatient.PatientAddress = textBoxAddressPM.Text;
                string gender = "";
                if (radioButtonMasculinePM.Checked == true)
                {
                    gender = "M";
                }
                else if (radioButtonFemininePM.Checked == true)
                {
                    gender = "F";
                }
                newPatient.PatientGender = gender;

                db.Patient.InsertOnSubmit(newPatient);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("New Patient added to the DB !");
                    resetData();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                
     
            }
         

        }

        private void buttonEditPM_Click(object sender, EventArgs e)
        {
            Patient actualPatient;

            if (textBoxCodePM.Text.Length == 0 || textBoxNamePM.Text.Length == 0 || (radioButtonFemininePM.Checked == false && radioButtonMasculinePM.Checked == false))
            {
                MessageBox.Show("You need to load a patient before Edit");
            }
            else
            {
                DialogResult answer = MessageBox.Show("This patient will be edided from the database ! ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.OK)
                {
                    actualPatient = db.Patient.First(patient => patient.PatientId.Equals(Convert.ToInt32(textBoxCodePM.Text)));
                    actualPatient.PatientName = textBoxNamePM.Text;
                    actualPatient.BirthDate = dateTimePickerBirthDatePM.Value;
                    actualPatient.PatientAddress = textBoxAddressPM.Text;
                    string gender = "";
                    if (radioButtonMasculinePM.Checked == true)
                    {
                        gender = "M";
                    }
                    else if (radioButtonFemininePM.Checked == true)
                    {
                        gender = "F";
                    }
                    actualPatient.PatientGender = gender;

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("The patient has been well edited !");
                        resetData();
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                
            }
        }

        private void buttonDeletePM_Click(object sender, EventArgs e)
        {
            Patient actualPatient;

            if (textBoxCodePM.Text.Length == 0 || textBoxNamePM.Text.Length == 0 || (radioButtonFemininePM.Checked == false && radioButtonMasculinePM.Checked == false))
            {
                MessageBox.Show("You need to load a patient before Edit");
            }
            else
            {
                DialogResult answer = MessageBox.Show("This patient will be deleted from the database ! ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (answer == DialogResult.OK)
                {
                    actualPatient = db.Patient.First(patient => patient.PatientId.Equals(Convert.ToInt32(textBoxCodePM.Text)));
                    db.Patient.DeleteOnSubmit(actualPatient);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("The patient has been well deleted !");
                        resetData();
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
                
            }

        }

        private void buttonExitPM_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you wan to exit?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
