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
using System.Windows.Shapes;

namespace _20_04WPFIntercambioDeDatos
{
    /// <summary>
    /// Lógica de interacción para venDestino.xaml
    /// </summary>
    public partial class venDestino : Window
    {
        public venDestino()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            tbcTitulo.Text = (Application.Current as App).Dato;
        }
    }
}
