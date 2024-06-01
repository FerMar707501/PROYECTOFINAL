using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace ProyectoFinalGasolineras
{
    internal class Abastecimiento
    {
        public int Bomba {  get; set; }
        public double GalonesPorDispensar {  get; set; }

        public Abastecimiento (int bomba, double galonesPorDispensar)
        {
            Bomba = bomba;
            GalonesPorDispensar = galonesPorDispensar;
        }
    }
}
