using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class course
    {
        private string namecourse;

        public course(string namecourse)
        {
            this.namecourse = namecourse;
        }
        
        public string Namecourse
        {
            get => namecourse;
            set
            {
                namecourse = value;
            }
        }
    }
}
