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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double y = double.Parse(BB.Text);
            string s = "";

            if (Pow(x - 0, 2) + Pow(y - 0, 2) <= Pow(10, 2) && y <= Abs(x))
            {
                if (Pow(x - 0, 2) + Pow(y - 0, 2) == Pow(10, 2))
                {
                    s = "На границе";
                }
                else { s = "Да"; }
            }
            else { s = "Нет"; }
            Rez.Text = $"{s}";
        }
    }
}
