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
    public partial class FrfCheckInCheckOut : Form
    {
        public FrfCheckInCheckOut()
        {
            InitializeComponent();
        }

        private void btnBuscaReservacionCliente_Click(object sender, EventArgs e)
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
                DGVIdClientes.DataSource = resultado;

                // Ejecuta la consulta para cargar los códigos de reservación en el ComboBox
                DataTable codigosReservacion = conexion.SelectCodigosReservacionPorApellidos(apellidoPaterno, apellidoMaterno);

                // Limpia el ComboBox de códigos de reservación antes de cargar los nuevos datos
                cbIdReservaciones.Items.Clear();

                // Itera sobre los resultados y agrega cada código de reservación al ComboBox
                foreach (DataRow fila in codigosReservacion.Rows)
                {
                    string codigoReservacion = fila["reserva_id"].ToString();
                    cbIdReservaciones.Items.Add(codigoReservacion);
                }

                // Seleccionar el primer elemento en el ComboBox si hay elementos disponibles
                if (cbIdReservaciones.Items.Count > 0)
                {
                    cbIdReservaciones.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se ha seleccionado un código de reservación en el ComboBox
                if (cbIdReservaciones.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un código de reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtén el código de reservación seleccionado en el ComboBox
                string codigoReservacion = cbIdReservaciones.SelectedItem.ToString();

                // Obtén la instancia de la conexión
                var conexion = ManagementCassandra.getInstance();

                // Ejecuta la consulta para actualizar el estado de la reservación
                conexion.ActualizarEstadoReservacion(codigoReservacion);

                // Actualiza el DataGridView con las reservaciones
                ActualizarReservaciones();

                MessageBox.Show("El estado de la reservación se actualizó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarReservaciones()
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
                DGVIdClientes.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las reservaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Verifica si se ha seleccionado un código de reservación en el ComboBox
                if (cbIdReservaciones.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un código de reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtén el código de reservación seleccionado en el ComboBox
                string codigoReservacion = cbIdReservaciones.SelectedItem.ToString();

                // Obtén la instancia de la conexión
                var conexion = ManagementCassandra.getInstance();

                // Ejecuta la consulta para actualizar el estado de la reservación
                conexion.ActualizarEstadoReservacionOut(codigoReservacion);

                // Actualiza el DataGridView con las reservaciones
                ActualizarReservaciones();

                MessageBox.Show("El estado de la reservación se actualizó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado de la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrincipalOperativos form10 = new MenuPrincipalOperativos();
            // Muestra el formulario Form2
            this.Hide();
            form10.ShowDialog();
        }
    }
}
