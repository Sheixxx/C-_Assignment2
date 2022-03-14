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
    public partial class ShowAll : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public ShowAll()
        {
            InitializeComponent();
        }

        private void radioButtonDoctors_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var info = (from x in db.Doctor select x).ToList();
                dataGridViewTables.DataSource = info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void radioButtonPatient_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var info = (from x in db.Patient select x).ToList();
                dataGridViewTables.DataSource = info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void radioButtonAppointment_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var info = (from x in db.Appointments select x).ToList();
                dataGridViewTables.DataSource = info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void dataGridViewTables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
