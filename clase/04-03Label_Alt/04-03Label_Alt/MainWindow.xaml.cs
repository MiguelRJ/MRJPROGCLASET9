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

namespace _04_03Label_Alt
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

        private void cbxCiudades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void lbxCiudades_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            this.Title = ((TextBlock)lbxCiudades.Items[lbxCiudades.SelectedIndex]).Text;
        }
    }
}
