using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class Reporte_OcupacionHotel : Form
    {
        public Reporte_OcupacionHotel()
        {
            InitializeComponent();

            // Establece la fecha actual en txtAnomes
            textBoxAñoMesOcpHotel.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void GenerarOcpHotel_Click(object sender, EventArgs e)
        {
            // Obtén los valores de los TextBox
            string contTextBox1 = textBoxCiudadOcpHotel.Text;
            string contTextBox2 = textBoxNombreHtlOcpHotel.Text;
            string contTextBox3 = textBoxAñoMesOcpHotel.Text;
            string contTextBox4 = textBoxTpoHabitOcpHotel.Text;
            string contTextBox5 = textBoxCanHabitOcpHotel.Text;
            string contTextBox6 = textBoxPorcentajeOcpHotel.Text;
            string contTextBox7 = textBoxCantidaPHospOcpHotel.Text;

            // Especifica la ruta del archivo de texto
            string rutaArchivo = "D:\\GuardadoReportes\\ReporteOcupacionHotel.txt"; // Cambia esto a la ruta deseada

            try
            {
                // Abre el archivo en modo de apendizado, si no existe, lo crea
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Escribe la fecha actual y una separación para cada reporte
                    sw.WriteLine("--------------------------------------------------");
                    sw.WriteLine("Fecha del reporte: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sw.WriteLine("--------------------------------------------------");

                    // Escribe el contenido de los TextBox en el archivo con formato
                    sw.WriteLine("Ciudad: " + contTextBox1);
                    sw.WriteLine("Nombre del Hotel: " + contTextBox2);
                    sw.WriteLine("Año y Mes: " + contTextBox3);
                    sw.WriteLine("Tipo de Habitación: " + contTextBox4);
                    sw.WriteLine("Cantidad de Habitaciones: " + contTextBox5);
                    sw.WriteLine("Porcentaje de Ocupación: " + contTextBox6);
                    sw.WriteLine("Cantidad de Personas Hospedadas: " + contTextBox7);
                    sw.WriteLine();
                }

                MessageBox.Show("Información guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelarOcpHotel_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            ReportesSistema form6 = new ReportesSistema();
            // Muestra el formulario Form2
            this.Hide();
            form6.ShowDialog();
        }

        private void Reporte_OcupacionHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
