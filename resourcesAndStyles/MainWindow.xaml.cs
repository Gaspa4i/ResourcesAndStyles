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

namespace resourcesAndStyles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double result;
                double distance = Convert.ToDouble(txtDistance.Text);
                double rasxod = Convert.ToDouble(txtRasxod.Text);
                double fuel = Convert.ToDouble(txtFuel.Text);
                result = (distance * rasxod) / 100;
                if (fuel >= result)
                {
                    lblResult.Content = "Бензина хватит";
                }
                else lblResult.Content = "Бензина не хватит";
            }
            catch
            {
                MessageBox.Show("Введите числа в каждое поле");
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDistance.Text = "";
            txtFuel.Text = "";
            txtRasxod.Text = "";
            lblResult.Content = "";
        }
    }
}
