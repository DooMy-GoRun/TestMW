using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMWCApp.Model
{
    public class Order
    {
        public int Nubmer { get; set; }
        public string NameOfCounterparty { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Staff> Staffs { get; set; }
    }
}
