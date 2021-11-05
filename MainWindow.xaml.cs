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

namespace Lab4WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDollar.Text);
            double sum = Convert.ToDouble(sumDollar.Text);
            double res = rate * sum;
            resDollar.Text = res.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateEuro.Text);
            double sum = Convert.ToDouble(sumEuro.Text);
            double res = rate * sum;
            resEuro.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateGrivna.Text);
            double sum = Convert.ToDouble(sumGrivna.Text);
            double res = rate * sum;
            resGrivna.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate = Convert.ToDouble(rateDrama.Text);
            double sum = Convert.ToDouble(sumDrama.Text);
            double res = rate * sum;
            resDrama.Text = res.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double dist = Convert.ToDouble(distFoot.Text);
            double res = dist * 0.3048;
            resFoot.Text = res.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double dist = Convert.ToDouble(distYard.Text);
            double res = dist * 0.9144;
            resYard.Text = res.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double dist = Convert.ToDouble(distInch.Text);
            double res = dist * 0.0254;
            resInch.Text = res.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double dist = Convert.ToDouble(distMile.Text);
            double res = dist * 1609.344;
            resMile.Text = res.ToString();
        }
    }
}
