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

namespace _03_27Sudoku3x3
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

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            LlenarGridAlea();
        }

        private void LlenarGridAlea()
        {
            List<int> listaNumeros = new List<int>(new int[]{1,2,3,4,5,6,7,8,9});
            Random rnd = new Random();
            int posicion = 0;
            for (int i = 0; i < Sudoko3x3.RowDefinitions.Count; i++)
            {
                for (int j = 0; j < Sudoko3x3.ColumnDefinitions.Count; j++)
                {
                    posicion = rnd.Next(listaNumeros.Count);
                    // Creo el objeto y asigno sus propiedades
                    TextBlock tbxTmp = new TextBlock();
                    tbxTmp.FontFamily = new FontFamily("Arial");
                    tbxTmp.FontSize = 75;
                    tbxTmp.VerticalAlignment = VerticalAlignment.Center;
                    tbxTmp.HorizontalAlignment = HorizontalAlignment.Center;
                    tbxTmp.Background = new SolidColorBrush(Colors.Crimson);
                    tbxTmp.Foreground = new SolidColorBrush(Colors.Goldenrod);
                    tbxTmp.Height = 80;
                    tbxTmp.Width = 80;
                    tbxTmp.Text = listaNumeros[posicion].ToString();
                    // Borro el valor entero asignado o extraido
                    listaNumeros.RemoveAt(posicion);
                    // Asigno las posiciones al control dentro de la rejilla
                    Grid.SetRow(tbxTmp, i);
                    Grid.SetColumn(tbxTmp, j);
                    //añado el elemento al grid
                    Sudoko3x3.Children.Add(tbxTmp);
                }
            }
        }
    }
}
