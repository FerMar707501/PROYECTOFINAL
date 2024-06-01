using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalGasolineras
{
    internal class DatosCliente
    {
        public string _Nombre {  get; set; }
        public string _Nit { get; set; }
        public int _NumCliente { get; set; }
        public double _CantidadGalones { get; set; }
        public double _PrecioGalon { get; set; }
        public double _Total { get; set; }
        public string _Fecha { get; set; }
        public string _Hora { get; set; }

        public DatosCliente(string fecha, string hora, string nombre, string nit, int numCliente, double cantidadGalones, double precioGalon, double total)
        {
            _Fecha = fecha;
            _Hora = hora;
            _Nombre = nombre;
            _Nit = nit;
            _NumCliente = numCliente;
            _CantidadGalones = cantidadGalones;
            _PrecioGalon = precioGalon;
            _Total = total;
        }
    }
}
