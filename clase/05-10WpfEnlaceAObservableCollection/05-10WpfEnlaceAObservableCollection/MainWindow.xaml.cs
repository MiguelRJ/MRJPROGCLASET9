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
//-------------------------
using Migue.Persona;

namespace _05_10WpfEnlaceAObservableCollection
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaPersonas _listaPersonas = null;

        public MainWindow()
        {
            InitializeComponent();
            _listaPersonas = new ListaPersonas();
            // Pongo los datos a disposicion de la lista que los muestra
            //livNombres.DataContext = _listaPersonas;
            livNombres.ItemsSource = _listaPersonas;
        }

        private void btnAnadirDatos_Click(object sender, RoutedEventArgs e)
        {
            // Añadir los datos de los textBox a la lista de personas
            if (txtNombre.Text.Length == 0 && txtApellidos.Text.Length == 0)
            {
                return;
            }
            try
            {
                _listaPersonas.Add(new Persona(txtNombre.Text, txtApellidos.Text, DateTime.Parse(txtFechaNacimiento.Text), double.Parse(txtEstatura.Text)));
                txtNombre.Clear();
                txtApellidos.Clear();
                txtFechaNacimiento.Clear();
                txtEstatura.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no son correctos");
            }
        }

        private void btnBorrarDatos_Click(object sender, RoutedEventArgs e)
        {
            // Borra el dato de la persona seleccionada
            if (livNombres.SelectedIndex == -1)
            {
                return;
            }
            _listaPersonas.RemoveAt(livNombres.SelectedIndex);
        }

        private void btnCambiarFechaSele_Click(object sender, RoutedEventArgs e)
        {
            // Cambia la fecha de nacimiento del elemento seleccionado
            if (livNombres.SelectedIndex == -1)
            {
                return;
            }
            Persona personaTmp = livNombres.SelectedItem as Persona;
            if (personaTmp == null)
            {
                return;
            }
            int posPersona = livNombres.SelectedIndex;
            personaTmp.FechaNacimiento = DateTime.Now;
            _listaPersonas.RemoveAt(posPersona);
            _listaPersonas.Insert(posPersona, personaTmp);
        }
    }
}
