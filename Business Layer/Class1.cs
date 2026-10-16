using PRG_role2_code_kb.Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_role2_code_kb.Business_Layer
{
   public class  BusinessLayer
    {
        DataHandler dh = new DataHandler();
        public BusinessLayer() { }
        public BindingSource source()
        {
            BindingSource src = new BindingSource();
            src.DataSource = dh.GetAnimals();
            return src;
        }
        
    }
}
