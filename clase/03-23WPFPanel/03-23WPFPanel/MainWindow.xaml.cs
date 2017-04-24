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

namespace _03_23WPFPanel
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (stpPanelBotones.Orientation == Orientation.Vertical)
            {
                stpPanelBotones.Orientation = Orientation.Horizontal;
            }
            else
            {
                stpPanelBotones.Orientation = Orientation.Vertical;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
