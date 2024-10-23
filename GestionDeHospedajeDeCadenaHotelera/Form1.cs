using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestionDeHospedajeDeCadenaHotelera.RegistrarUsuarios;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class InicioSes1 : Form
    {
        string datoSeleccionado;
        public InicioSes1()
        {
            InitializeComponent();
        }

        private void buttonAccederIniciSes_Click(object sender, EventArgs e)
        {
            string p1 = textBoxUsuarioIniciSes.Text;
            string p2 = textBoxpassIniciSes.Text;

            var conexion = ManagementCassandra.getInstance();
            DataTable resultado = conexion.LoginUsuarios(datoSeleccionado,p1,p2);

            if (resultado.Rows.Count != 0)
            {
                DatoCompartido.TextoCompartido = p1;
                //Reservaciones form1 = new Reservaciones();
                // Crea una instancia del formulario Form2
                if(datoSeleccionado== "Administrador")
                {
                    MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
                    // Muestra el formulario Form2
                    this.Hide();
                    form1.ShowDialog();
                }
                if (datoSeleccionado == "Operativo")
                {
                    MenuPrincipalOperativos form1 = new MenuPrincipalOperativos();
                    // Muestra el formulario Form2
                    this.Hide();
                    form1.ShowDialog();
                }





            }
            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Aviso", MessageBoxButtons.OK);
            }


        }

        private void buttonSalirInicSes_Click(object sender, EventArgs e)
        {

            Application.Exit();


            //FORMS CON EL QUE JALA MENU PRINCIPAL DE USUARIOS OPERATIVOS

            //// Crea una instancia del formulario Form2
            //MenuPrincipalOperativos form10 = new MenuPrincipalOperativos();
            //// Muestra el formulario Form2
            //this.Hide();
            //form10.ShowDialog();
        }

        private void InicioSes1_Load(object sender, EventArgs e)
        {
            List<string> datos = new List<string>
            {
                "Administrador",
                "Operativo"
                // Agrega más elementos según sea necesario
            };

            // Asigna la lista como fuente de datos para el ComboBox
            comboBox1.DataSource = datos;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datoSeleccionado = comboBox1.SelectedItem.ToString();
        }
    }
}
