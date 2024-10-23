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
    public partial class RegistroTiposDeHabitacion : Form
    {
        string us;
        public RegistroTiposDeHabitacion()
        {
            InitializeComponent();
        }

        private void RegistroTiposDeHabitacion_Load(object sender, EventArgs e)
        {
            // Llama a la función para cargar las ciudades de los hoteles en el ComboBox
            CargarCiudadesHoteles();
        }

        private void CargarCiudadesHoteles()
        {
            // Llama a la función para seleccionar las ciudades de los hoteles
            var conexion = ManagementCassandra.getInstance();
            DataTable dtCiudades = conexion.SelectHoteles();

            // Limpia el ComboBox
            comboBox1.Items.Clear();

            // Agrega las ciudades de los hoteles al ComboBox
            foreach (DataRow row in dtCiudades.Rows)
            {
                string ciudad = row["nombre_hotel"].ToString();
                comboBox1.Items.Add(ciudad);
            }
        }

        private void buttonCancelarRegsTypeRoom_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario MenuPrinicpalAdmin
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario MenuPrinicpalAdmin
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonAceptarRegsTypeRoom_Click(object sender, EventArgs e)
        {
            string d1 = comboBox1.Text;
            string d2 = textBoxNoCamasRegTypeRooms.Text;
            string d3 = textBoxTypebedRegTypeRooms.Text;
            string d4 = textBoxpriceRegTypeRooms.Text;
            string d5 = textBoxNivelHab.Text;
            string d6 = textBoxCapacidadHotel.Text;
            string d7 = textBoxCaracHabi.Text;
            int n1 = int.Parse(d2); ;
            float n2 = float.Parse(d4);
            int n3 = int.Parse(d6);

            us = DatoCompartido.TextoCompartido;

            var conexion3 = ManagementCassandra.getInstance();
            conexion3.insertHabitaciones(d1, n1, d3, n2, d5, n3, d7, us);
            MessageBox.Show("Tipo De Habitacion Registrada", "Registrar", MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes agregar código para manejar el evento cuando se selecciona una ciudad en el ComboBox
            // Por ejemplo, podrías filtrar los hoteles por la ciudad seleccionada y mostrarlos en otro control del formulario.
        }
    }
}
