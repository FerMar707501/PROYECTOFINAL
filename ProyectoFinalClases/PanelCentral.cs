using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    internal class PanelCentral
    {
        private List<bombasGasolina> bombas;
        private List<Abastecimiento> abastecimientos;

        public PanelCentral(int numBombas)
        {
            bombas = new List<bombasGasolina>();
            abastecimientos = new List<Abastecimiento>();

            // Crear bombas
            for (int i = 1; i <= 4; i++)
            {
                bombas.Add(new bombasGasolina(i));
            }
        }

        public void IniciarAbastecimiento(int bombaID, bool prePago, double cantidad)
        {
            bombas[bombaID - 1].IniciarAbastecimiento(prePago, cantidad);
            RegistrarAbastecimiento(DateTime.Now, "Javier", prePago ? TipoAbastecimiento.Prepago : TipoAbastecimiento.TanqueLleno, cantidad);
        }

        public void DetenerAbastecimiento(int bombaID)
        {
            bombas[bombaID - 1].DetenerAbastecimiento();
        }

        public void InformeDiario()
        {
            
        }

        public void InformePrepago()
        {
            
        }

        public void InformeTanqueLleno()
        {
            
        }

        public int BombaMasUtilizada()
        {
           
            return 0;
        }

        public int BombaMenosUtilizada()
        {
          
            return 0;
        }

        private void RegistrarAbastecimiento(DateTime fechaHora, string cliente, TipoAbastecimiento tipo, double cantidad)
        {
            abastecimientos.Add(new Abastecimiento(fechaHora, cliente, tipo, cantidad));
        }
    }

    public enum TipoAbastecimiento
    {
        Prepago,
        TanqueLleno
    }

}

