using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class ReporteVentas : Form
    {
        public ReporteVentas()
        {
            InitializeComponent();

            // Establece la fecha actual en txtAnomes
            txtAnomes.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //Fecha
            txtAnomes.KeyPress += TextBoxFecha_KeyPress;
        }




        private void TextBoxFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo cifras, letras, la barra inclinada (/) 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }

            // --Validar de fecha
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '/')
            {
                string input = txtAnomes.Text + e.KeyChar;

                // ---Validarlo
                DateTime result;
                if (!DateTime.TryParseExact(input, "ddMMMyyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out result))
                {
                    e.Handled = true;
                }
            }
        }


        private void buttonGenerarVentas_Click(object sender, EventArgs e)
        {
            // Obtén el contenido de los TextBox
            string contenidoTextBox1 = textBoxCiudadRventas.Text;
            string contenidoTextBox2 = textBoxNHotelRVentas.Text;
            string contenidoTextBox3 = txtAnomes.Text;
            string contenidoTextBox4 = textBoxIngHospedajesRVentas.Text;
            string contenidoTextBox5 = textBoxIngrSvAdci.Text;
            string contenidoTextBox6 = textBoxIngTot.Text;

            // Especifica la ruta del archivo de texto
            string rutaArchivo = "D:\\GuardadoReportes\\ReporteVentas.txt"; // Cambia esto a la ruta deseada

            try
            {
                // Abre el archivo en modo de añadir, si no existe, lo crea
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    // Escribe la fecha actual
                    sw.WriteLine("=============================================");
                    sw.WriteLine($"Reporte de Ventas - {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                    sw.WriteLine("=============================================");

                    // Escribe el contenido de los TextBox en el archivo con formato
                    sw.WriteLine($"Ciudad: {contenidoTextBox1}");
                    sw.WriteLine($"Nombre del Hotel: {contenidoTextBox2}");
                    sw.WriteLine($"Año y Mes: {contenidoTextBox3}");
                    sw.WriteLine($"Ingresos por Hospedajes: {contenidoTextBox4}");
                    sw.WriteLine($"Ingresos por Servicios Adicionales: {contenidoTextBox5}");
                    sw.WriteLine($"Ingresos Totales: {contenidoTextBox6}");
                    sw.WriteLine("---------------------------------------------");
                    sw.WriteLine();
                }

                MessageBox.Show("Información guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la información: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCancelarRVentas_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario Form2
            ReportesSistema form6 = new ReportesSistema();
            // Muestra el formulario Form2
            this.Hide();
            form6.ShowDialog();
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAoMesRVentas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
