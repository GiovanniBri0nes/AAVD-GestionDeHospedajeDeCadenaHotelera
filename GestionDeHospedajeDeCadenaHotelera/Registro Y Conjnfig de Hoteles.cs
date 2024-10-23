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
    public partial class Registro_Y_Conjnfig_de_Hoteles : Form
    {
        public Registro_Y_Conjnfig_de_Hoteles()
        {
            InitializeComponent();
        }

        private void buttonAceptRegsHotel_Click(object sender, EventArgs e)
        {
            string dt1 = textBoxNombreHotel.Text;
            string dt2 = textBoxUbicCiudad.Text;
            string dt3 = textBoxUbicEstado.Text;
            string dt4 = textBoxUbicPais.Text;
            string dto5 = textBoxDomicilioRegsHotel.Text;
            string dto6 = textBoxNoPisosRegsHotel.Text;
            string dto7 = textBoxCantidadHabitREgsHotel.Text;
            string dto8 = textBoxZnTuristRegsHotel.Text;
            string dto9 = textBoxServAdcRegsHotel.Text;
            string dto10 = textBoxCaractHotel.Text;
            DateTime fecha2 = dateTimePickerHoteles.Value;

            int nuPi = int.Parse(dto6);
            int nuHab = int.Parse(dto7);


            string correo = DatoCompartido.TextoCompartido;



            if (string.IsNullOrEmpty(dt1) ||
                 string.IsNullOrEmpty(dt2) ||
                 string.IsNullOrEmpty(dt3) ||
                 string.IsNullOrEmpty(dt4) ||
                 string.IsNullOrEmpty(dto5) ||
                 string.IsNullOrEmpty(dto6) ||
                 string.IsNullOrEmpty(dto7) ||
                 string.IsNullOrEmpty(dto8) ||
                 string.IsNullOrEmpty(dto9) ||
                 string.IsNullOrEmpty(dto10))
            {

                MessageBox.Show("No se puede dejar ningún campo en blanco. Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var conexion2 = ManagementCassandra.getInstance();
                conexion2.insertHoteles(dt1, dt2, dt3, dt4, dto5, nuPi, nuHab, dto8, dto9, dto10, correo, fecha2);
                MessageBox.Show("Se ha registrado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCancelsrRegsHotel_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario Form2
            this.Hide();
            form1.ShowDialog();
        }

        private void Registro_Y_Conjnfig_de_Hoteles_Load(object sender, EventArgs e)
        {

        }
    }
}
