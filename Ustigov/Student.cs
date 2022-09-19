using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp1
{
    public class Student : INotifyPropertyChanged
    {
        public static int EmployeeId = 0;
        private string name;
        private string surname;
        private string patronimyc;
        private string department;

        public Student(string name, string surname, string patronimyc, string position, string department)
        {
            Name = name;
            Surname = surname;
            Patronimyc = patronimyc;
            Id = ++EmployeeId;
            Department = department;
        }

        public int Id { get; private set; }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChnged(new PropertyChangedEventArgs("Name"));
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChnged(new PropertyChangedEventArgs("Surname"));
            }
        }
        public string Patronimyc
        {
            get => patronimyc;
            set
            {
                patronimyc = value;
                OnPropertyChnged(new PropertyChangedEventArgs("Patronimyc"));
            }
        }
        public string Department
        {
            get => department;
            set
            {
                department = value;
                OnPropertyChnged(new PropertyChangedEventArgs("Department"));
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