using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project
{
    public class Class_Purchase
    {
        public List<Class_Merchandise> In { get; set; }
        public int cash { get; set; }
        public DateTime Date { get; set; }
        public Class_Account account { get; set; }
    }
}





