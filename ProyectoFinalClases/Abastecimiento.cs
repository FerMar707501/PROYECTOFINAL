using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    internal class Abastecimiento
    {
        public DateTime FechaHora { get; private set; }
        public string Cliente { get; private set; }
        public TipoAbastecimiento Tipo { get; private set; }
        public double Cantidad { get; private set; }

        public Abastecimiento(DateTime fechaHora, string cliente, TipoAbastecimiento tipo, double cantidad)
        {
            FechaHora = fechaHora;
            Cliente = cliente;
            Tipo = tipo;
            Cantidad = cantidad;
        }

        public double CalcularPrecioTotal(double precioPorLitro)
        {
            
            return Cantidad * precioPorLitro;
        }
    }

}

