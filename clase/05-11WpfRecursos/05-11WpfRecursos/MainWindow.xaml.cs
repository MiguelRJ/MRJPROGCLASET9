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

namespace _05_11WpfRecursos
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Cambiar el color de fondo aplicando recursos
            SolidColorBrush brocha = this.Resources["colorFondo2"] as SolidColorBrush;
            SolidColorBrush brocha2 = Application.Current.Resources["colorFondo6"] as SolidColorBrush;
            tbxMuestra.Background = brocha2;
        }
    }
}
