using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Collections.ObjectModel;

namespace Migue._04_27EnlacePersonas
{
    public class ListaPersonas : ObservableCollection<Persona>
    {
        Random rnd = new Random();

        // Creo una lista con varias personas

        public ListaPersonas():base() // Cuando heredo de otra clase lo normal es llamar a su constructor vacio
        {
            Add(new Persona("Pepe", "Rodriguez",CrearFechaNacimiento(), CrearEstatura()));
            Add(new Persona("Juan", "Sanchez", CrearFechaNacimiento(), CrearEstatura()));
            Add(new Persona("Elena", "Guzman", CrearFechaNacimiento(), CrearEstatura()));
            Add(new Persona("Pepito", "Gruillo", CrearFechaNacimiento(), CrearEstatura()));
            Add(new Persona("Platanito", "Figura", CrearFechaNacimiento(), CrearEstatura()));
        }

        private DateTime CrearFechaNacimiento()
        {
            // Crea una fecha aleatoria entre 18 y 30 años
            DateTime fecha = new DateTime();
            fecha = DateTime.Now - TimeSpan.FromDays(rnd.Next(365 * 18, 355 * 100));
            return fecha;
        }
        private double CrearEstatura()
        {
            // Creo estatura entre 1.50 y 2.10
            double estatura = rnd.Next(150, 211);
            estatura /= 100;
            return estatura;
        }
    }
}
