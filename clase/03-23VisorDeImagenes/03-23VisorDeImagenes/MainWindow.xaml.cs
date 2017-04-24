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

namespace _03_23VisorDeImagenes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] sources = null;
        int moverfoto = 0;
        public MainWindow()
        {
            InitializeComponent();
            CargarImgagenes();

        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            Uri strimg = new Uri(sources[moverfoto]);
            moverfoto--;
            BitmapImage imagen = new BitmapImage(strimg);
            imgMostrar.Source = imagen;
            ComprobarBotones();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            Uri strimg = new Uri(sources[moverfoto]);
            moverfoto++;
            BitmapImage imagen = new BitmapImage(strimg);
            imgMostrar.Source = imagen;
            ComprobarBotones();
        }

        private void ComprobarBotones()
        {
            if (moverfoto == 0)
            {
                btnAnterior.IsEnabled = false;
            }
            if (moverfoto == sources.Length)
            {
                btnSiguiente.IsEnabled = false;
            }
        }

        private void CargarImgagenes()
        {
            sources = new string[]{@"D:\Escritorio\VisorImg\1.jpg",
                                   @"D:\Escritorio\VisorImg\2.jpg",
                                   @"D:\Escritorio\VisorImg\3.jpg",
                                   @"D:\Escritorio\VisorImg\4.jpg",
                                   @"D:\Escritorio\VisorImg\5.jpg"};
        }
    }
}
