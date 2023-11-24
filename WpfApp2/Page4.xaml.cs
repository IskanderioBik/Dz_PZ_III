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
using static System.Math;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(BB.Text);
            int k = int.Parse(AA.Text);
            double? y = 0;

            switch (k)
            {
                case 3: Rez.Text = $"y = {Sin(x) + 2}"; break;
                case 20: Rez.Text = $"y = {Cos(Pow(x, 2))}"; break;
                case int t when t == 10 || t == 15: Rez.Text = $"y = { Tan(x) + Sin(x)}"; break;
                default: Rez.Text = $"y = Неопределено"; break;
            }
        }
    }
}
