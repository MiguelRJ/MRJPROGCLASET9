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

namespace _04_03TextPass
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string CLAVE = "12345";
        const string USUARIO = "alumno";
        const int NINTENTOS = 3;
        string clave;
        string usuario;
        int nIntentos = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            //Win_Entrada entrada = new Win_Entrada();
            //entrada.ShowDialog();ç
            usuario = tbxUser.Text;
            clave = tbxPass.Password;
            if (usuario == USUARIO && clave == CLAVE)
            {
                //se permite acceder al sistema
                this.Hide();
                new Win_Entrada().ShowDialog();
            }
            else
            {
                nIntentos++;
                MessageBox.Show("ERROR: Identiicacion incorrecta");
                if (nIntentos >= NINTENTOS)
                {
                    MessageBox.Show("Demasiadoa intentos...");
                    this.Close();
                }
            }
        }
    }
}
