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

namespace WpfApp1
{
    /// Combobox comboBox = sender as Combobox;
    /// combobox.
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;

            ComboBoxItem cbi = comboBox.SelectedItem as ComboBoxItem;
            if (cbi == null) return;

            FontFamily =new FontFamily(cbi.Content as string);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = sender as Slider;
            if (slider == null) return;

            FontSize = slider.Value;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton == null) return;

            int aling = 0;
            if (int.TryParse(radioButton.DataContext as string, out aling))
            {
                textblock.TextAlignment = (TextAlignment)aling;
            }
         
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton1 = sender as RadioButton;
            if (radioButton1 == null) return;

            int style = 0;
            if (int.TryParse(radioButton1.DataContext as string, out style))
            {
                if (style == 0)
                {

                    textblock.FontStyle = FontStyles.Normal;

                }
                else if (style == 1)
                {
                    textblock.FontStyle = FontStyles.Oblique;
                }
                else
                {
                    return;
                }
            }


        }
      
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            switch (check.IsChecked.Value)
            {
                case true:
                    check.Content = "Жирный";
                    textblock.FontWeight = FontWeights.Bold;
                    break;
                case false:
                    check.Content = "Нормальный";
                    textblock.FontWeight= FontWeights.Normal;
                    break;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox1 = sender as ComboBox;
            if (comboBox1 == null) return;

            ComboBoxItem item = comboBox1.SelectedItem as ComboBoxItem;
            if (item == null) return;
            
            
            switch ((string)item.Content)
            {   
                case "Красный":
                    textblock.Foreground = Brushes.Red;
                    break;
                case "Серый":
                    textblock.Foreground = Brushes.Gray;
                    break;
                case "Жёлтый":
                    textblock.Foreground = Brushes.Yellow;
                    break;
                case "Синий":
                    textblock.Foreground = Brushes.Blue;
                    break;

            }
        }


    }

}
