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
//--------------------------------
using Migue._04_27EnlacePersonas;

namespace _04_27EnlacePersonas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona persona = null;
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            // Poner el contexto de datos al Grid
            persona = new Persona();
            grdDatos.DataContext = persona;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Obtiene una persona aleatoriamente
            persona = new ListaPersonas()[rnd.Next(new ListaPersonas().Count)];
            grdDatos.DataContext = persona;
        }

        private void btnCambiarNombre_Click(object sender, RoutedEventArgs e)
        {
            persona.Nombre = "D.eliseo el jefe";
        }
    }
}
