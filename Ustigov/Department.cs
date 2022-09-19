using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    public class Department : INotifyPropertyChanged
    {
        private string nameDepartment;

        public Department(string nameDepartment)
        {
            NameDepartment = nameDepartment;
        }

        public string NameDepartment
        {
            get => nameDepartment;
            set
            {
                nameDepartment = value;
                OnPropertyChnged(new PropertyChangedEventArgs("NameDepartment"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChnged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
