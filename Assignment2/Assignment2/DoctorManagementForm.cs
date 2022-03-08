using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Assignment2
{
    public partial class DoctorManagementForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DoctorManagementForm()
        {
            InitializeComponent();
            //var docteurId = from x in db.Doctor select x.DoctorId;

            //var patientId = from x in db.Patient select x.PatientId;

            var dbPersoQuery = from perso in db.Patient select perso;
            foreach (var elt in dbPersoQuery)
            {
                Console.WriteLine(elt.PatientName + " " + elt.PatientAddress);
            }
        }

        private void buttonNewDM_Click(object sender, EventArgs e)
        {
            textBoxCodeDM.Clear();
            textBoxNameDM.Clear();
            textBoxSpecialtyDM.Clear();
            textBoxTelephoneDM.Clear();
            dateTimePickerHiringDate.Value = DateTime.Now;
        }

        private void buttonSearchDM_Click(object sender, EventArgs e)
        {
 
        }

        private void buttonExitDM_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
