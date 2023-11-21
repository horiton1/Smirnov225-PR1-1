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

namespace Prak1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(R1TextBox.Text, out double R1)) MessageBox.Show("Поле только для чисел");
            if (!double.TryParse(R2TextBox.Text, out double R2)) MessageBox.Show("Поле только для чисел");
            double p = 3.14;
            double s1 = p * Math.Pow(R1, 2);
            double s2 = p * Math.Pow(R2, 2);
            double s3 = s1 - s2;
            S1TextBox.Text += s1;
            S2TextBox.Text += s2;
            S3TextBox.Text += s3;
        }
    }
}
