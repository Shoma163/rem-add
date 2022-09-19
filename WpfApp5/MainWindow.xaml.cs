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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public product selectproduct { get; set; }
        public List<product> classItem { get; set; } = new List<product>();
        public float sum { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            classItem.Add(new product("Apple", 150));
            classItem.Add(new product("Bread", 42));
            classItem.Add(new product("Banana", 54));
            classItem.Add(new product( "Mint",  50));
            classItem.Add(new product("Orange", 108));
            classItem.Add(new product("Rice", 115));
            classItem.Add(new product("Liver pies", 45));
            classItem.Add(new product("Coffee", 450));
            classItem.Add(new product("Milk", 73));


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selectproduct == null) return;
            listBoxSecond.Items.Add(selectproduct);

            sum += selectproduct.Price;
            lableSum.GetBindingExpression(Label.ContentProperty).UpdateTarget();

            listBox.SelectedIndex = -1;
        }
    }
}
