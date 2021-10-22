using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Demo_App.DataBase
{
    public partial class DemandSet
    {
        public string Address => Address_City + ", " + Address_House + ", " + Address_Street + ", " + Address_Number;

    }
}
