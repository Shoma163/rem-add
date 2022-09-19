using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Npgsql;
using NpgsqlTypes;

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        private NpgsqlConnection connection;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Connect("10.14.206.27", "5432", "student", "1234", "Lukina363");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EnableControl(true);

            ButtonCreate.Content = "Зафикстровать изменения";
            ButtonCreate.Click -= Button_Click;
            ButtonCreate.Click += Confirm;
        }
        private void Confirm(object sender, RoutedEventArgs e)
        {
            EnableControl(false);

            ButtonCreate.Content = "Новый сотрудник";
            ButtonCreate.Click += Button_Click;
            ButtonCreate.Click -= Confirm;


            NpgsqlCommand command = new NpgsqlCommand();
        }

        private void EnableControl(bool isEnable)
        {
            foreach (UIElement element in CreateNewEmployee.Children)
            {
                if (element.GetType() == typeof(TextBox) ||
                    element.GetType() == typeof(ComboBox))
                {
                    element.IsEnabled = isEnable;
                }
            }
        }

        private void Connect(string host, string port, string user, string password, string database)
        {
            string cs = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", host, port, user, password, database);

            connection = new NpgsqlConnection(cs);
            connection.Open();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string positionName = TextBoxNewPosition.Text.Trim();
            if (positionName.Length == 0) return;

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO \"Department\"(namedepartment) VALUES(@namedepartment)";
            command.Parameters.AddWithValue("@namedepartment", NpgsqlDbType.Varchar, positionName);
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Отделение успешно добавлено!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string positionName = TextBoxNewPosition1.Text.Trim();
            if (positionName.Length == 0) return;

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO \"Specialization\"(namespecialty) VALUES(@namespecialty)";
            command.Parameters.AddWithValue("@namespecialty", NpgsqlDbType.Varchar, positionName);
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Специализация успешно добавлена!");
            }
        }
    

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string positionName = TextBoxNewPosition2.Text.Trim();
            if (positionName.Length == 0) return;

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO \"Course\"(namecourse) VALUES(@namecourse)";
            command.Parameters.AddWithValue("@namecourse", NpgsqlDbType.Integer, positionName);
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Курс успешно добвлен!");
            }
        }
        private void LoadCommand()
        {

        }
        private void LoadEmployees()
        {
        }


    }
}
  
