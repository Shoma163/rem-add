using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustigov
{
    public class Cours
    {
        private string namecours;

        public Cours(string namecours)
        {
            this.Namecours = namecours;
        }

        public string Namecours
        {
            get => namecours;
            set
            {
                namecours = value;
            }
        }
    }
}
