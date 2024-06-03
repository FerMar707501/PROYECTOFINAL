using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ProyectoFinalGasolineras
{
    //internal class Abastecimiento
    public class Abastecimiento
    {
        public int Bomba {  get; set; }
        public double GalonesPorDispensar {  get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Nueva propiedad Tipo


        public Abastecimiento(int bomba, double galonesPorDispensar, string tipo)
        {
            Bomba = bomba;
            GalonesPorDispensar = galonesPorDispensar;
            Fecha = DateTime.Now; // Asignar la fecha actual si es necesario
            Tipo = tipo;
        }
    }
}
