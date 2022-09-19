using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Group
    {
        private string namegroup;
        private string department;
        private string course;
        private string specialization;

        public Group(string namegroup, string department, string course, string specialization)
        {
            this.namegroup = namegroup;
            this.department = department;
            this.course = course;
            this.specialization = specialization;
        }

        public string Namegroup
        {
            get => namegroup;
            set
            {
                namegroup = value;
            }
        }
        public string Department 
        { get => department;
          set
            {
                department = value;
            }
        }
        public string Course
        {
            get => course;
            set
            {
                course = value;
            }
        }
        public string Specialization
        {
            get => specialization;
            set
            {
                specialization = value;
            }
        }
    }
}
