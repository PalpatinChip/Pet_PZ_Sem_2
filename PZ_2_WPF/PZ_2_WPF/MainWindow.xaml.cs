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

namespace PZ_2_WPF
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int x1 = 0;
            int x2 = 0;
            try
            {
                x1 = Convert.ToInt32(this.txtBox1.Text);
                x2 = Convert.ToInt32(this.txtBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("ОШИБКА! ВВЕДЕНО ИЛИ НЕКОРЕКТНЫЕ ЗНАЧЕНИЯ, ИЛИ НЕ ВВЕДЕНЫ ВОВСЕ!");
                return;
            }
            int s = Math.Abs(x1 - x2);

            this.txtBox3.Text = Convert.ToString(s);
        }
    }
}
