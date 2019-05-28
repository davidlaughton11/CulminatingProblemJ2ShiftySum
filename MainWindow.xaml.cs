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

namespace CulminatingProblemJ2ShiftySum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            double k;
            double N;
            double output = 0;
            double.TryParse(kInput.Text, out k);
            double.TryParse(NInput.Text, out N);

            if (k > 0)
            {
                output = output + N;
            }
            for (int i = 1; i <= k; i++)
            {               
                int x = 0;
                N = N * (10 * Math.Exp(x));
                x = x + 1;
                output = output + N;
            }            
            lblOuput.Content = output;
        }
    }
}
