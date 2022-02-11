using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project
{
    public class Class_Template_Template_Merchandise
    {
        public string Name { get; set; }
        public string  Unit { get; set; }
        public int Minimum { get; set; }
        public enum Type
        {
            Hyper1,
            Hyper2,
            vegetable,
            fruits
        }
    }
}
