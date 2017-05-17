using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.Collections.ObjectModel;//lista observavble con otras funcionalidades

namespace Migue._05_08MaestroDetalleDirector
{
    class Director : Notificador
    {
        ObservableCollection<Film> _filmes;
        public string Nombre { get; set; }
        public string nacionalidad { get; set; }
        public ObservableCollection<Film> Filmes 
        { 
            get { return  _filmes; }
            set { _filmes = value; }
        }
        public Director()
        {
            _filmes = new ObservableCollection<Film>();
        }
    }
}
