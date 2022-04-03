using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Business_ConsultationForm : Data_Access
    {
        public Business_ConsultationForm()
        {

        }
        public DataTable Select()
        {
            base.link();
            string Query = "Student";
            DataTable outPut = base.SelectedData("*",Query);
            base.unLink();
            return outPut;
        }
    }
}
