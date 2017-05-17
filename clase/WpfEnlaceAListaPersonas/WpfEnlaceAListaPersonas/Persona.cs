using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------
using System.Windows.Media.Imaging;

namespace Sebas.Wpf_EnlacesDataContextAClases
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private Double estatura;
        private BitmapImage foto;


        public Persona()
        {
            // Creo una persona con los datos de prueba
            this.nombre = "Sebastián";
            this.apellidos = "Millán García";
            this.fechaNacimiento = DateTime.Parse("03/03/1900");
            this.estatura = 1.69;
        }


        public Persona(string nombre, string apellidos, DateTime fechaNacimiento, Double estatura)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.estatura = estatura;
        }

        public Persona(string nombre, string apellidos, DateTime fechaNacimiento, Double estatura, BitmapImage foto)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.estatura = estatura;
            this.foto = foto;
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public BitmapImage Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}

