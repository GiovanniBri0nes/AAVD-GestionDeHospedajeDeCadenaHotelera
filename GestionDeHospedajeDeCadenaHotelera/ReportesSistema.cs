using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class ReportesSistema : Form
    {
        public ReportesSistema()
        {
            InitializeComponent();
        }

        private void buttonRegresarReportSistema_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario Form2
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonRpOcpHotel_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            Reporte_OcupacionHotel form7 = new Reporte_OcupacionHotel();
            // Muestra el formulario Form2
            this.Hide();
            form7.ShowDialog();
        }

        private void buttonRptVentasRpSISTEMA_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            ReporteVentas form8 = new ReporteVentas();
            // Muestra el formulario Form2
            this.Hide();
            form8.ShowDialog();
        }

        private void ReportesSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
