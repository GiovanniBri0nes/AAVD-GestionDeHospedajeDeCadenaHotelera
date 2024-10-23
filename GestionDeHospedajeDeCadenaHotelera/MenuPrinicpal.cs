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
    public partial class MenuPrinicpalAdmin : Form
    {
        public MenuPrinicpalAdmin()
        {
            InitializeComponent();
        }

        private void MenuPrinicpalAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegsUsuOper_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            RegistrarUsuarios form2 = new RegistrarUsuarios();
            // Muestra el formulario Form2
            this.Hide();
            form2.ShowDialog();
            
        }

        private void buttonRegsYConfHotels_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            Registro_Y_Conjnfig_de_Hoteles form3 = new Registro_Y_Conjnfig_de_Hoteles();
            // Muestra el formulario Form2
            this.Hide();
            form3.ShowDialog();
        }

        private void buttonTypeRooms_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            RegistroTiposDeHabitacion form4 = new RegistroTiposDeHabitacion();
            // Muestra el formulario Form2
            this.Hide();
            form4.ShowDialog();
        }

        private void buttonCancelaciones_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            Cancelaciones form5 = new Cancelaciones();
            // Muestra el formulario Form2
            this.Hide();
            form5.ShowDialog();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            ReportesSistema form6 = new ReportesSistema();
            // Muestra el formulario Form2
            this.Hide();
            form6.ShowDialog();
        }

        private void buttonHistorialAdmin_Click(object sender, EventArgs e)
        {

            // Crea una instancia del formulario Form2
            HistorialCliente form9 = new HistorialCliente();
            // Muestra el formulario Form2
            this.Hide();
            form9.ShowDialog();
        }

        private void buttonCerrarSesionMenuAdmin_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            InicioSes1 form0 = new InicioSes1();
            // Muestra el formulario Form2
            this.Hide();
            form0.ShowDialog();
        }
    }
}
