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
    .Select(g => new { Fecha = g.Key, TotalGalones = g.Sum(a => a.GalonesPorDispensar) });

            var prepagos = datosAbastecimientos.Where(a => a.Tipo == "Prepago");
            var tanqueLleno = datosAbastecimientos.Where(a => a.Tipo == "TanqueLleno");

            var bombaMasUtilizada = datosAbastecimientos.GroupBy(a => a.Bomba)
                .OrderByDescending(g => g.Count()).FirstOrDefault();
            var bombaMenosUtilizada = datosAbastecimientos.GroupBy(a => a.Bomba)
                .OrderBy(g => g.Count()).FirstOrDefault();

            listViewEstadisticas.Items.Clear();

            listViewEstadisticas.Items.Add("Cierres de Caja Diarios:");
            var cierresDiariosText = string.Join("\n", cierresDiarios.Select(cierre => $"{cierre.Fecha.ToShortDateString()}: {cierre.TotalGalones} galones"));
            listViewEstadisticas.Items.Add(cierresDiariosText);

            listViewEstadisticas.Items.Add("\nAbastecimientos Prepago:");
            var prepagosText = string.Join("\n", prepagos.Select(prepago => $"Bomba {prepago.Bomba}: {prepago.GalonesPorDispensar} galones"));
            listViewEstadisticas.Items.Add(prepagosText);

            listViewEstadisticas.Items.Add("\nAbastecimientos Tanque Lleno:");
            var tanqueLlenoText = string.Join("\n", tanqueLleno.Select(tanque => $"Bomba {tanque.Bomba}: {tanque.GalonesPorDispensar} galones"));
            listViewEstadisticas.Items.Add(tanqueLlenoText);

            if (bombaMasUtilizada != null)
            {
                listViewEstadisticas.Items.Add($"\nBomba Más Utilizada: Bomba {bombaMasUtilizada.Key} - {bombaMasUtilizada.Count()} veces");
            }

            if (bombaMenosUtilizada != null)
            {
                listViewEstadisticas.Items.Add($"\nBomba Menos Utilizada: Bomba {bombaMenosUtilizada.Key} - {bombaMenosUtilizada.Count()} veces");
            }
            
        }

        private void EstadisticasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
