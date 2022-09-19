using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;
using NpgsqlTypes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private NpgsqlConnection connection;
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Connect("10.14.206.27", "5432", "student", "1234", "Ustigov");
        }
        private void Connect(string host, string port, string user, string pass, string dbname)
        {
            string cs = string.Format("Server={0};Port={1};User ID={2};Password={3};DataBase={4}", host, port, user, pass, dbname);

            connection = new NpgsqlConnection(cs);
            connection.Open();
        }
    }
}