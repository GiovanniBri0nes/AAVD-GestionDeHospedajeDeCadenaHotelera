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
using Cassandra;
using Cassandra.Mapping;


namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class Reservaciones : Form
    {
        int algo;
        string si;
        string dd="";//hotel
        string nm;
        string ap;
        string am;
        string n;
        string m;
        string ciudad;
        float j;

        public Reservaciones()
        {
            InitializeComponent();
        }

        private void buttonAceptarReservaciones_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores de los controles
                string nombre = txtNom.Text; // Asumiendo que tienes un TextBox para el nombre
                string apellidoPaterno = txtAP.Text; // Asumiendo que tienes un TextBox para el apellido paterno
                string apellidoMaterno = TXTAM.Text; // Asumiendo que tienes un TextBox para el apellido materno
                string ciudad = comboBoxCiudadReservaciones.Text; // Asumiendo que tienes un TextBox para la ciudad
                string nombreHotel = CBNomHotel.Text; // Asumiendo que el nombre del hotel está en un ComboBox
                string numHab = cbNumeroHabitacion.Text; // Asumiendo que tienes un TextBox para el número de habitación
                float precio = float.Parse(txtPrecioHabitacion.Text); // Asumiendo que tienes un TextBox para el precio
                DateTime fechaInicio = dateTimePickerNacimientoRegUser.Value; // Asumiendo que tienes un DateTimePicker para la fecha de inicio
                DateTime fechaFin = dateTimePicker1.Value; // Asumiendo que tienes un DateTimePicker para la fecha de fin
                float anticipo = float.Parse(textBox3.Text); // Asumiendo que tienes un TextBox para el anticipo
                string metodoPago = cbFormadePago.Text; // Asumiendo que tienes un TextBox para el método de pago
                string usuarioRegistro = DatoCompartido.TextoCompartido; // Asumiendo que tienes un dato compartido para el usuario

                // Validaciones básicas
                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno) ||
                    string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(nombreHotel) || string.IsNullOrEmpty(numHab) ||
                    string.IsNullOrEmpty(metodoPago) || string.IsNullOrEmpty(usuarioRegistro))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              

                // Obtén la instancia de la conexión
                var conexion = ManagementCassandra.getInstance();

                // Llama al método para insertar la reserva
                Guid codigoReservacion = conexion.InsertarReserva(
                    nombre,
                    apellidoPaterno,
                    apellidoMaterno,
                    ciudad,
                    nombreHotel,
                    numHab,
                    precio,
                    fechaInicio,
                    fechaFin,
                    anticipo,
                    metodoPago,
                    usuarioRegistro
                );

                // Muestra el mensaje de éxito con el código de reservación
                string mensaje = $"Reservación registrada con éxito. Código de Reservación: {codigoReservacion}";
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelarReservaciones_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrincipalOperativos form10 = new MenuPrincipalOperativos();
            // Muestra el formulario Form2
            this.Hide();
            form10.ShowDialog();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            algo = 1;//Apellido
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            algo = 2;//RFC
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            algo = 3;//CorreoElectronico
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            si = "Tarjeta De Credito";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            si = "Tarjeta De Credito";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            si = "Transferencia Bancaria";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            si = "Efectivo";
        }

        private void buttonBusqReservaciones_Click(object sender, EventArgs e)
        {
            string bu = textBox1.Text;
            var conexion = ManagementCassandra.getInstance();
            DataTable resultado = conexion.SelectUsuarios2(algo, bu);

            dataGridViewBusquedaResevaciones.DataSource = resultado;

            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];
                txtNom.Text = fila["nombre"].ToString();
                txtAP.Text = fila["a_paterno"].ToString();
                TXTAM.Text = fila["a_materno"].ToString();
            }
            else
            {
                // Si no se encontraron resultados, limpia los TextBox
                LimpiarTextBox();
            }

            }

        private void LimpiarTextBox()
        {

            txtNom.Text = "";
            txtAP.Text = "";
            TXTAM.Text = "";
        }

            private void Reservaciones_Load(object sender, EventArgs e)
        {

            var conexion = ManagementCassandra.getInstance();
            DataTable dt = conexion.SelectCiudadess();

            // Nombre de la columna que deseas usar para llenar el ComboBox
            string nombreColumna = "ubicacion_ciudad";

            // Limpia el ComboBox antes de agregar nuevos elementos
            comboBoxCiudadReservaciones.Items.Clear();

            // Itera a través de las filas y agrega los valores de la columna al ComboBox
            foreach (DataRow row in dt.Rows)
            {
                // Asegúrate de que la columna exista antes de intentar obtener su valor
                if (dt.Columns.Contains(nombreColumna))
                {
                    comboBoxCiudadReservaciones.Items.Add(row[nombreColumna].ToString());
                }
            }
        }

        private void comboBoxCiudadReservaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = comboBoxCiudadReservaciones.SelectedItem;
            string ciudad = selectedItem.ToString();

            var conexion = ManagementCassandra.getInstance();
            DataTable resultado = conexion.SelectHoteles(ciudad);

            dataGridViewHotelesyCaracteristicas.DataSource = resultado;

            // Limpia el ComboBox antes de llenarlo con nuevos datos
            CBNomHotel.Items.Clear();

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    CBNomHotel.Items.Add(fila["nombre_hotel"].ToString());
                }

                // Si deseas seleccionar automáticamente el primer hotel en el ComboBox
                if (CBNomHotel.Items.Count > 0)
                {
                    CBNomHotel.SelectedIndex = 0;
                }
            }
            else
            {
                // Si no se encontraron resultados, limpia el ComboBox y los TextBox
                CBNomHotel.Text = string.Empty;
                LimpiarTextBox();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre del hotel desde el ComboBox
                string nombreHotel = CBNomHotel.Text;

                // Verifica que el nombre del hotel no esté vacío
                if (string.IsNullOrEmpty(nombreHotel))
                {
                    MessageBox.Show("Por favor, selecciona un hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtén la instancia de la conexión y ejecuta la consulta para cargar los datos en el DataGridView
                var conexion = ManagementCassandra.getInstance();
                DataTable resultado = conexion.SelectHabitacionesPorHotel(nombreHotel);

                // Asigna el resultado al DataGridView
                dataGridView1.DataSource = resultado;

                // Llama a la función para cargar los datos en el ComboBox
                CargarNumeroCamasEnComboBox(nombreHotel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarNumeroCamasEnComboBox(string nombreHotel)
        {
            try
            {
                // Obtén la instancia de la conexión y ejecuta la consulta para cargar los datos en el ComboBox
                var conexion = ManagementCassandra.getInstance();
                DataTable resultado = conexion.SelectNumHabitacion(nombreHotel);

                // Limpiar el ComboBox de número de habitación antes de cargar los nuevos datos
                cbNumeroHabitacion.Items.Clear();

                // Verificar y depurar el número de filas obtenidas
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron números de camas para el hotel seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Itera sobre los resultados y agrega cada número de camas al ComboBox
                foreach (DataRow fila in resultado.Rows)
                {
                    // Convertir el valor a string antes de añadirlo al ComboBox
                    string numeroCama = fila["numero_camas"].ToString();
                    cbNumeroHabitacion.Items.Add(numeroCama);

                    // Mensaje de depuración
                    Console.WriteLine("Número de camas agregado al ComboBox: " + numeroCama);
                }

                //// Seleccionar el primer elemento en el ComboBox si hay elementos disponibles
                //if (cbNumeroHabitacion.Items.Count > 0)
                //{
                //    cbNumeroHabitacion.SelectedIndex = 0;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de número de camas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }











        private void dataGridViewHotelesyCaracteristicas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHotelesyCaracteristicas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada (puedes ajustar según tus necesidades)
                DataGridViewRow selectedRow = dataGridViewHotelesyCaracteristicas.SelectedRows[0];

                // Itera a través de las celdas de la fila para encontrar la celda en la columna "Nombre"
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    // Verifica si es la celda de la columna "Nombre"
                    if (cell.OwningColumn.Name == "nombre_hotel")
                    {
                        // Obtén el valor de la celda
                        object valorCelda = cell.Value;

                        // Ahora puedes utilizar valorCelda según tus necesidades
                        dd = valorCelda.ToString();

                        // Puedes detener la búsqueda una vez que encuentres la celda deseada
                        break;
                    }
                }

            }

        }

        private void dataGridViewBusquedaResevaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBusquedaResevaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBusquedaResevaciones.SelectedRows[0];

                // Obtiene los valores de las celdas directamente por nombre de columna
                nm = selectedRow.Cells["nombre"].Value?.ToString();
                ap = selectedRow.Cells["a_paterno"].Value?.ToString();
                am = selectedRow.Cells["a_materno"].Value?.ToString();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Obtener los valores de las celdas directamente por nombre de columna
                string numeroCamas = selectedRow.Cells["numero_camas"].Value?.ToString();
                string precioNochePorPersona = selectedRow.Cells["precio_noche_por_persona"].Value?.ToString();

                // Actualizar ComboBox de número de habitación si es necesario
                if (!string.IsNullOrEmpty(numeroCamas))
                {
                    cbNumeroHabitacion.SelectedItem = numeroCamas;
                }

               
            }
        }

       


        private void dateTimePickerNacimientoRegUser_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CBNomHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNumeroHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtén el nombre del hotel desde el ComboBox
                string nombreHotel = CBNomHotel.Text;

                // Verifica que el nombre del hotel no esté vacío
                if (string.IsNullOrEmpty(nombreHotel))
                {
                    MessageBox.Show("Por favor, selecciona un hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtén el número de camas seleccionado
                if (cbNumeroHabitacion.SelectedItem != null)
                {
                    int numeroCamasSeleccionado = int.Parse(cbNumeroHabitacion.SelectedItem.ToString());

                    // Obtén la instancia de la conexión y ejecuta la consulta para obtener el precio
                    var conexion = ManagementCassandra.getInstance();
                    DataTable resultado = conexion.SelectPrecioHabitacion(nombreHotel, numeroCamasSeleccionado);

                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        txtPrecioHabitacion.Text = fila["precio_noche_por_persona"].ToString();
                    }
                    else
                    {
                        txtPrecioHabitacion.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el precio de la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}



