using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// -----------------------------------------------
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace Migue.Wpf_EnlacesDataContextAClases
{
    public class ListaPersonas : ObservableCollection<Persona>
    {
        Random rnd = new Random();
        List<BitmapImage> fotos = new List<BitmapImage>();

        // Crea una lista con varias personas
        public ListaPersonas()
            : base()
        {
            LlenarListaFotos();
            Add(new Persona("Pepe", "Rodríguez", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
            Add(new Persona("Isaac", "Dinesen", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
            Add(new Persona("Victor", "Hugo", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
            Add(new Persona("Julio", "Verne", CrearFechaNacimiento(), CrearEstatura(), CrearFoto()));
        }

        private DateTime CrearFechaNacimiento()
        {
            // Crea una fecha aleatoria de los últimos 20 años
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(1, 365 * 20));
            return fecha;
        }

        private double CrearEstatura()
        {
            // Crea una esatura aleatoria entre 1.50 y 2.10
            Double estatura = rnd.Next(150, 211);
            estatura /= 10;
            return estatura;
        }

        private BitmapImage CrearFoto()
        {
            return fotos[rnd.Next(fotos.Count)];
        }

        private void LlenarListaFotos()
        {
            // Añade varias imágenes a la lista
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img1.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img2.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img3.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img4.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img5.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img6.jpg", UriKind.Relative)));
            fotos.Add(new BitmapImage(new Uri("./../../Imagenes/imgCaricaturas/img7.jpg", UriKind.Relative)));
        }

       
    }
}
