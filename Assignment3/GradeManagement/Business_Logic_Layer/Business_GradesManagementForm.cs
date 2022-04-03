using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class Business_GradesManagementForm : Data_Access
    {
        public DataTable Select()
        {
            base.link();
            string Query = "Select * from Student";
            DataTable outPut = base.SelectedData(Query);
            base.unLink();
            return outPut;
        }
    }
}
