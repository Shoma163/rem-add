using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustigov
{
    public class Group
    {
        private string nameGroup;
        private string department;
        private string cours;
        private string specialization;

        public Group(string nameGroup, string department, string cours, string specialization)
        {
            this.NameGroup = nameGroup;
            this.Department = department;
            this.Cours = cours;
            this.Specialization = specialization;
        }

        public string NameGroup 
        { 
            get => nameGroup; 
            set 
            { 
                nameGroup = value; 
            } 
        }
        public string Department 
        { 
            get => department;
            set
            { 
                department = value; 
            }
        }
        public string Cours 
        { 
            get => cours; 
            set 
            { 
                cours = value;
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
