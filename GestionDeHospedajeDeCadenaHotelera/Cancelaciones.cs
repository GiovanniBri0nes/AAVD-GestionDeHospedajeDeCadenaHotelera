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
    public partial class Cancelaciones : Form
    {
        public Cancelaciones()
        {
            InitializeComponent();
        }

        private void Cancelaciones_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegresarCancelaciones_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario Form2
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonAceptarCancelaciones_Click(object sender, EventArgs e)
        {   string us = DatoCompartido.TextoCompartido;
            string cod = cbCodigoReservacion.Text;
            string motivos = textBox1.Text;


            var conexion3 = ManagementCassandra.getInstance();
            conexion3.InsertCancelacion(cod,us, motivos);


            MessageBox.Show("Cancelacion Aceptada", "Registrar", MessageBoxButtons.OK);
        }

        private void btnCargarReservacionesCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén los apellidos desde los TextBoxes
                string apellidoPaterno = txtApellidoPaterno.Text;
                string apellidoMaterno = txtApellidoMaterno.Text;

                // Verifica que los apellidos no estén vacíos
                if (string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno))
                {
                    MessageBox.Show("Por favor, ingresa ambos apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtén la instancia de la conexión y ejecuta la consulta para cargar las reservas en el DataGridView
                var conexion = ManagementCassandra.getInstance();
                DataTable resultado = conexion.SelectReservasPorApellidos(apellidoPaterno, apellidoMaterno);

                // Asigna el resultado al DataGridView
                dataGridView1.DataSource = resultado;

                // Ejecuta la consulta para cargar los códigos de reservación en el ComboBox
                DataTable codigosReservacion = conexion.SelectCodigosReservacionPorApellidos(apellidoPaterno, apellidoMaterno);

                // Limpia el ComboBox de códigos de reservación antes de cargar los nuevos datos
                cbCodigoReservacion.Items.Clear();

                // Itera sobre los resultados y agrega cada código de reservación al ComboBox
                foreach (DataRow fila in codigosReservacion.Rows)
                {
                    string codigoReservacion = fila["reserva_id"].ToString();
                    cbCodigoReservacion.Items.Add(codigoReservacion);
                }

                // Seleccionar el primer elemento en el ComboBox si hay elementos disponibles
                if (cbCodigoReservacion.Items.Count > 0)
                {
                    cbCodigoReservacion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
