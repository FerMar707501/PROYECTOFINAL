using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    internal class bombasGasolina
    {
        public int ID { get; private set; }
       

        public bombasGasolina(int id)
        {
            ID = id;
           
        }
        public void IniciarAbastecimiento(bool prePago, double cantidad)
        {
           
            
            Console.WriteLine($"Bomba {ID}: Abastecimiento iniciado - Tipo: {(prePago ? "Prepago" : "Tanque lleno")} - Cantidad: {cantidad} litros");
        }
        public void DetenerAbastecimiento()
        {
            
           
            Console.WriteLine($"Bomba {ID}: Abastecimiento detenido");
        }
    }
}
