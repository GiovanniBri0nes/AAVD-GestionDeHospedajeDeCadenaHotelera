using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static GestionDeHospedajeDeCadenaHotelera.RegistrarUsuarios;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class GestionDeClientes : Form
    {
        public GestionDeClientes()
        {
            InitializeComponent();
        }

        private void buttonAceptarGestionClientes_Click(object sender, EventArgs e)
        {
            string dto1 = textBoxNombreCGestionUsuarios.Text;
            string dto1_1 = textBox1.Text;
            string dto1_2 = textBox2.Text;
            string dto2 = textBoxDomicilioGestionUser.Text;
            string dto3 = textBoxRFCGestionClientes.Text;
            string dto4 = textBoxCorreoGestionCLientes.Text;
            string dto5 = textBoxTelefonoGestionClientes.Text;
            string dto6 = TelefonoCelularGestionClientes.Text;
            string dto7 = textBoxReferenciaGestionClientes.Text;
            DateTime dto8 = dateTimePickerFevhaNcGestionClientes.Value;
            string seleccion = comboBoxEstadoCivilGestionClientes.SelectedItem as string;

            string use = DatoCompartido.TextoCompartido;

            var conexion = ManagementCassandra.getInstance();
            conexion.insertClientes(dto1,dto1_1,dto1_2, dto2, dto3, dto4, dto5, dto6,dto7,dto8,seleccion,use);

            MessageBox.Show(" Cliente Registrado", "Registrar", MessageBoxButtons.OK);

        }

        private void buttonCancelarGestionClientes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrincipalOperativos form10 = new MenuPrincipalOperativos();
            // Muestra el formulario Form2
            this.Hide();
            form10.ShowDialog();
        }

        private void GestionDeClientes_Load(object sender, EventArgs e)
        {
            List<string> opciones = new List<string> { "Soltero(a)", "Casado(a)", "Divorciado(a)"," Viudo(a)" };
            comboBoxEstadoCivilGestionClientes.Items.AddRange(opciones.ToArray());
        }
    }
}
