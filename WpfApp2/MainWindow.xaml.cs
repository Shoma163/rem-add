using System;
using System.Collections.Generic;
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

namespace WpfApp2
{
  
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0) return;

            string newItem = textBox.Text.Trim();
            if (comboBox.Items.Contains(newItem))
            {
                MessageBox.Show("Данный элемент уже существует");
                return;
            }

            comboBox.Items.Add(textBox.Text.Trim());
            textBox.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var rem = comboBox.SelectedItem;
            if (textBox.Text.Length == 0) 
            {
                comboBox.Items.Remove(rem);
            };
           comboBox.Items.Remove(textBox.Text.Trim());
           textBox.Text = "";
        }
        //selectedItems
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (comboBox.Items.Count == 0)
            {
                MessageBox.Show("ComboBox пуст");
                return;
            }

            comboBox.Items.Clear();
        }
    }
}
