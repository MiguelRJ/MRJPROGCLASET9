using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migue._04_24EnlaceDatosClaseFilm
{
    public enum Genero { Mafia, Drama, Catatofismo, Aventuras, Comedia, Oeste, CianciaFiccion};

    class Film
    {
        string _titulo;
        Genero _genero;
        bool? _oscar;
        double _calificacion;

        public Film(string titulo, Genero genero, bool? oscar, double calificacion)
        {
            this._titulo = titulo;
            _genero = genero;
            _oscar = oscar;
            _calificacion = calificacion;
        }
        public Film() { }
        
        //Propiedades
        public string Titulo
        {
            get {return _titulo; }
            set { _titulo = value;}
        }

        public Genero Genero
        {
            get {return _genero;}
            set { _genero=value;}
        }

        public bool? Oscar
        {
            get {return _oscar;}
            set {_oscar = value;}
        }
        public double Calificacion
        {
            get {return _calificacion;}
            set {_calificacion = value;}
        }

    }
}
