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

namespace _04_20WpfEventosEnrutados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            // se lanza en cada movimiento del raton
            tbx1.Text = "(" + e.GetPosition(this).X + "," + e.GetPosition(this).Y + ")"+e.Source.GetType().Name;
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            e.Handled = true;
        }
    }
}
