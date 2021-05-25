using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMWCApp.Model
{
    public class Department
    {
        public string Title { get; set; }
        public virtual Staff Staffs { get; set; }
    }
}
