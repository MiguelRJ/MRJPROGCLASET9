using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------
using System.ComponentModel;

namespace Migue._04_27EnlacePersonas
{
    public class Persona : INotifyPropertyChanged
    {
        string _nombre;
        string _apellido;
        DateTime _fechaNacimiento;
        double _estatura;

        public Persona()
        {
            // Creo una persona por defecto
            _nombre = "Yo mismo";
            _apellido = "Tu mismo";
            _fechaNacimiento = DateTime.Now;
            _estatura = 0.0;
        }

        public Persona(string nombre, string apellido, DateTime fechaNacimiento, double estatura)
        {
            // Creo una persona por defecto
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
            _estatura = estatura;
        }

        public string Nombre
        {
            get { return _nombre; }
            set 
            { 
                _nombre = value;
                MetodoAuxiliarCambio("Nombre");
            }
        }

        public string Apellido
        {
            get { return _apellido; }
            set 
            { 
                _apellido = value;
                MetodoAuxiliarCambio("Apellido");
            }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set 
            { 
                _fechaNacimiento = value;
                MetodoAuxiliarCambio("FechaNacimineto");
            }
        }

        public double Estatura
        {
            get { return _estatura; }
            set 
            { 
                _estatura = value;
                MetodoAuxiliarCambio("Estatura");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void MetodoAuxiliarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
    }
}
