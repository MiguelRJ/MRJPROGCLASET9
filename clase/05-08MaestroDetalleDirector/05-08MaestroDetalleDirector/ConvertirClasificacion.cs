using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Windows.Data;
using System.Globalization;

namespace Migue._05_08MaestroDetalleDirector
{
    [ValueConversion(typeof(double),typeof(string))]
    class ConvertirClasificacion:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Convierte el valor entero de la clasificacion en letras
            string[] valoresLetras = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco" };
            // Comprobaciones previas
            if (targetType == typeof(string) && value.GetType() == typeof(double))
            {
                return valoresLetras[(int)Math.Round((double)value)];
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Metodo ConvertBack no esta codificado");
        }
    }
}
