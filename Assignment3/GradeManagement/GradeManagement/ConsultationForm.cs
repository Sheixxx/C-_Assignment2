using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic_Layer;

namespace GradeManagement
{
    public partial class ConsultationForm : Form
    {

        Business_ConsultationForm bf = new Business_Logic_Layer.Business_ConsultationForm();

        public ConsultationForm()
        {
            InitializeComponent();
            DataTable toto = bf.Select();
            dataGridView1.DataSource = toto;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
