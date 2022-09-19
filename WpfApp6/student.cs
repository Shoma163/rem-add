using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp6
{
    public class student {
        private string group;
        private string name;
        private string surname;
        private string middlename;

        public student(string group, string name, string surname, string middlename) {
            this.group = group;
            this.name = name;
            this.surname = surname;
            this.middlename = middlename;
        }
        public string Group
        {
            get => group; 
            set { 
                group = value; 
            }
        }
        public string Name
        {
            get => name;
            set { 
                name = value; 
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
            }
        }
        public string Meddlename
        {
            get => middlename;
            set
            {
                middlename = value;
            }
        }

    }
}
