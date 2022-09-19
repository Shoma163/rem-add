using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class specialization
    {
        private string namespecialty;

        public specialization(string namespecialty)
        {
            this.namespecialty = namespecialty;
        }
        public string Namespecialty
        {
            get => namespecialty;
            set 
            { 
                namespecialty = value; 
            }
        }
    }
}
