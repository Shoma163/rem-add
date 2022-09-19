using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Department
    {
        private string namedepartment;

        public Department(string namedepartment)
        {
            this.namedepartment = namedepartment;
        }
        public string Namedepartment
        {
            get => namedepartment;
            set
            {
                namedepartment = value;
            }
        }
    }
}
