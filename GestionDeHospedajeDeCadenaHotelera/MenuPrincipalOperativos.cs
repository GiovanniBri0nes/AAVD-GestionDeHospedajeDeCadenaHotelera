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
    public partial class MenuPrincipalOperativos : Form
    {
        public MenuPrincipalOperativos()
        {
            InitializeComponent();
        }

        private void ButtonReservaciones_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            Reservaciones form11 = new Reservaciones();
            // Muestra el formulario Form2
            this.Hide();
            form11.ShowDialog();
        }

        private void buttonGestionClientes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            GestionDeClientes form12 = new GestionDeClientes();
            // Muestra el formulario Form2
            this.Hide();
            form12.ShowDialog();
        }

        private void MenuPrincipalOperativos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            InicioSes1 form0 = new InicioSes1();
            // Muestra el formulario Form2
            this.Hide();
            form0.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            FrfCheckInCheckOut form2 = new FrfCheckInCheckOut();
            // Muestra el formulario Form2
            this.Hide();
            form2.ShowDialog();
        }
    }
}
