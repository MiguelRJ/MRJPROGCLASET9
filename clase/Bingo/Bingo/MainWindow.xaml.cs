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

namespace Bingo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TextBlock> listaTxtblk = new List<TextBlock>();
        List<int> bolas = new List<int>();
        Random rnd = new Random();

        public MainWindow()
        {
            int numerosDeBolas = 1;
            InitializeComponent();
            for (int i = 0; i < gridTablaNum.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < gridTablaNum.ColumnDefinitions.Count; j++)
                {
                    //<TextBlock x:Name="txtblk00" Text="1" FontSize="20" Grid.Column="0" Grid.Row="0" TextAlignment="Center"/>
                    TextBlock tmp = new TextBlock();
                    tmp.Name="txtblk"+i.ToString()+j.ToString();
                    tmp.Text=numerosDeBolas.ToString();
                    numerosDeBolas++;
                    tmp.FontSize=20;
                    tmp.TextAlignment= TextAlignment.Center;
                    Grid.SetRow(tmp,i);
                    Grid.SetColumn(tmp,j);
                    listaTxtblk.Add(tmp);
                    gridTablaNum.Children.Add(tmp);
                }
            }
            RellenarBolas();
        }

        /// <summary>
        /// Rellenar el bombo de bolas 
        /// vacia la lista de bolas, porque sino las suma
        /// hace el metodo LabelNumBolas()
        /// </summary>
        private void RellenarBolas()
        {
            int numerosDeBolas = 1;
            //string stringpureba = "";
            bolas.RemoveRange(0, bolas.Count);
            for (int i = 1; i <= 90; i++)
            {
                //stringpureba += numerosDeBolas.ToString()+",";
                bolas.Add(numerosDeBolas);
                numerosDeBolas++;
            }
            //MessageBox.Show(stringpureba);
            LabelNumBolas();
        }

        /// <summary>
        /// escribe el numero de bolas que quedan por sacar
        /// </summary>
        private void LabelNumBolas()
        {
            lblNumBolasNum.Content = bolas.Count;
        }

        /// <summary>
        /// resetea el fondo de todos los textblock de la rejilla de numeros
        /// </summary>
        private void ResetFondoDeTxtblx()
        {
            for (int i = 0; i < listaTxtblk.Count; i++)
			{
                listaTxtblk[i].Background = new SolidColorBrush(Colors.White);
                listaTxtblk[i].Background.Opacity = 0;
			}
            lblUltimoNum.Text = "";
            cmbxCrono.Items.Clear();
        }

        /// <summary>
        /// boton de la barra de heerramientas
        /// cuando haga click al boton hara los metodos RellenarBolas(); y ResetFondoDeTxtblx();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToolBarJuegoNuevo_Click(object sender, RoutedEventArgs e)
        {
            RellenarBolas();
            ResetFondoDeTxtblx();
        }

        /// <summary>
        /// boton del menu superior
        /// cuando haga click al boton hara los metodos RellenarBolas(); y ResetFondoDeTxtblx();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            RellenarBolas();
            ResetFondoDeTxtblx();
        }

        /// <summary>
        /// boton principal de extraer bolas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtraerBola_Click(object sender, RoutedEventArgs e)
        {
            if (bolas.Count == 0)
            {
                MessageBox.Show("Juego acabado, empieze uno nuevo");
                lblUltimoNum.Text = "FIN";
            }
            else
            {
                int numero = 0;
                int alea = rnd.Next(bolas.Count); //obtengo un numero aleatorio entre 0 y el count del bombo de bolas (bolas que quedan)
                numero = bolas[alea]; // obtengo el numero de la posicion aleatoria antes obetenia (miro el numero de la bola)
                bolas.RemoveAt(alea); // retiro la bola de la posicion que acabo de sacar (saco la bola del bombo)
                lblUltimoNum.Text = numero.ToString(); //muestro la bola que he sacado 
                listaTxtblk[numero-1].Background = new SolidColorBrush(Colors.Red);// doy al textblock el color en la posicion del numero de bola extraido
                LabelNumBolas();// actualizo el label con el numero de bolas que quedan
                cmbxCrono.Items.Add(numero);//añado el numero que ha salido 
                cmbxCrono.SelectedIndex = cmbxCrono.Items.Count - 1;
            }
        }

        /// <summary>
        /// boton de cerrar la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult opcion = MessageBox.Show("¿Estas seguro de que quieres salir?", "Salir de la aplicacion", MessageBoxButton.YesNo);
            if (opcion == MessageBoxResult.Yes)
            {
                Application.Current.MainWindow.Close();
            }
        }

        
    }
}
