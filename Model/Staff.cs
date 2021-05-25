using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMWCApp.Model
{
    public class Staff
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        enum Gender { male, female }
        public virtual Department Departments { get; set; }
    }
}
