using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalGasolineras
{
    public partial class EstadisticasForm : Form
    {
        private List<Abastecimiento> datosAbastecimientos;
        public EstadisticasForm(List<Abastecimiento> datosAbastecimientos)
        {
            InitializeComponent();
            this.datosAbastecimientos = datosAbastecimientos;
            GenerarEstadisticas();
        }
        private void GenerarEstadisticas()
        {
             var cierresDiarios = datosAbastecimientos.GroupBy(a => a.Fecha.Date)
            .Select(g => new { Fecha = g.Key, TotalGalones = g.Sum(a => a.GalonesPorDispensar)

           var prepagos = datosAbastecimientos.Where(a => a.Tipo == "Prepago");
            var tanqueLleno = datosAbastecimientos.Where(a => a.Tipo == "TanqueLleno");

           var bombaMasUtilizada = datosAbastecimientos.GroupBy(a => a.Bomba)
                .OrderByDescending(g => g.Count()).FirstOrDefault();
            var bombaMenosUtilizada = datosAbastecimientos.GroupBy(a => a.Bomba)
                .OrderBy(g => g.Count()).FirstOrDefault();

           listBoxEstadisticas.Items.Clear();

            listBoxEstadisticas.Items.Add("Cierres de Caja Diarios:");
            foreach (var cierre in cierresDiarios)
            {
                listBoxEstadisticas.Items.Add($"{cierre.Fecha.ToShortDateString()}: {cierre.TotalGalones} galones");
            }

            listBoxEstadisticas.Items.Add("\nAbastecimientos Prepago:");
            foreach (var prepago in prepagos)
            {
                listBoxEstadisticas.Items.Add($"Bomba {prepago.Bomba}: {prepago.GalonesPorDispensar} galones");
            }

            listBoxEstadisticas.Items.Add("\nAbastecimientos Tanque Lleno:");
            foreach (var tanque in tanqueLleno)
            {
                listBoxEstadisticas.Items.Add($"Bomba {tanque.Bomba}: {tanque.GalonesPorDispensar} galones");
            }

            if (bombaMasUtilizada != null)
            {
                listBoxEstadisticas.Items.Add($"\nBomba Más Utilizada: Bomba {bombaMasUtilizada.Key} - {bombaMasUtilizada.Count()} veces");
            }

            if (bombaMenosUtilizada != null)
            {
                listBoxEstadisticas.Items.Add($"\nBomba Menos Utilizada: Bomba {bombaMenosUtilizada.Key} - {bombaMenosUtilizada.Count()} veces");
            
        }

        private void EstadisticasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
