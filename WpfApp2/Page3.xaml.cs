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
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(AA.Text);
            int b = int.Parse(BB.Text);
            int c = int.Parse(CC.Text);
            int j = 0;
            if (b == c) { j = 1; } else if (a == c) { j = 2; } else { j = 3; }
            Rez.Text = $"Число отличное от других {j}";
        }
    }
}
