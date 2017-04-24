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

namespace _03_30WPFPaneles
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        static double VerticalOffset = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Application.Current.MainWindow.Background = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
        }

        private void btnPos_Click(object sender, RoutedEventArgs e)
        {
            SVTexto.ScrollToVerticalOffset(VerticalOffset += 50);
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            SVTexto.ScrollToVerticalOffset(VerticalOffset -= 50);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Application.Current.MainWindow.Background = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
        }

        private void TextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox_KeyUp_1(object sender, KeyEventArgs e)
        {

        }
    }
}
