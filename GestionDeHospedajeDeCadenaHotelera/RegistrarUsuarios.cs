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
    public partial class RegistrarUsuarios : Form
    {
        bool uno;
        public static string TextoCompartido;
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        public class DatoCompartido
        {
            public static string TextoCompartido;
        }


        private void buttonAceptarRegsUsuarios_Click(object sender, EventArgs e)
        {
            string correo = textBoxCoreoRegUser.Text;
            string contraseña = textBoxpassRegUser.Text;
            string nombre = textBoxNmCompRegUser.Text;
            string numeroNom = textBoxNoNominaRegUser.Text;
            DateTime Fecha = dateTimePickerNacimientoRegUser.Value;
            string Domicilio = textBoxDomicilioRegUser.Text;
            string tel1 = textBoxTelefonoRegUser.Text;
            string tel2 = textboxcelcel.Text;

            if (uno == true)
            {
                var conexion = ManagementCassandra.getInstance();
                conexion.insertUsuario(correo, contraseña, nombre, numeroNom, Fecha, Domicilio, tel1, tel2);
                //conexion.insertUsuario2();
                MessageBox.Show(" Usuario Registrado", "Registrar", MessageBoxButtons.OK);
                TextoCompartido = correo;

            }
            else
            {
                var conexion = ManagementCassandra.getInstance();
                conexion.insertOperador(correo, contraseña, nombre, numeroNom, Fecha, Domicilio, tel1, tel2);
                MessageBox.Show("Usuario Operador Registrado", "ok", MessageBoxButtons.OK);
            }

        }

        private void buttonCancelarRegsUser_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario Form2
            this.Hide();
            form1.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            uno = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            uno = false;
        }

        private void RegistrarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
