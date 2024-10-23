using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeHospedajeDeCadenaHotelera
{
    public partial class HistorialCliente : Form
    {
        public HistorialCliente()
        {
            InitializeComponent();

          
        }

        ///VALIDACIONES EN TEXT BOX  

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            // Separador de miles o  decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;  
                return;
            }

            // Pa que no haya más de un separador 
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                return;
            }

            //signo de pesos Inicio
            if ((e.KeyChar == '$') && ((sender as TextBox).Text.Length == 0))
            {
                e.Handled = false;
                return;
            }

            // Solo dos decimales
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                (sender as TextBox).Text.IndexOf('.') == -1 && (sender as TextBox).Text.IndexOf(',') == -1)
            {
                if ((sender as TextBox).Text.Length > 0 && (sender as TextBox).Text.Length - (sender as TextBox).Text.IndexOf('.') > 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            //Solo números después del signo
            if ((sender as TextBox).Text.Length == 1 && (sender as TextBox).Text[0] == '$' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }


        private void TextBoxFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }





        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario MenuPrinicpalAdmin
            MenuPrinicpalAdmin form1 = new MenuPrinicpalAdmin();
            // Muestra el formulario MenuPrinicpalAdmin
            this.Hide();
            form1.ShowDialog();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            
        }

        
        private void LlenarComboBoxCriterioBusqueda()
        {
           
        }



        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCriterioBusqueda();
        }

        private void buttonBuscarHistorialClient_Click(object sender, EventArgs e)
        {

            try
            {
                // Obtener los apellidos de los TextBox
                string apellidoPaterno = textApellidoPaterno.Text.Trim();
                string apellidoMaterno = txtApellidoMaterno.Text.Trim();

                // Verificar que los apellidos no estén vacíos
                if (string.IsNullOrEmpty(apellidoPaterno) || string.IsNullOrEmpty(apellidoMaterno))
                {
                    MessageBox.Show("Por favor, ingrese ambos apellidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar a la función para obtener las reservas
                var conexion = ManagementCassandra.getInstance(); // Asegúrate de que esta instancia esté configurada correctamente
                DataTable resultado = conexion.SelectReservasPorApellidosCompleto(apellidoPaterno, apellidoMaterno);

                // Verificar si se encontraron resultados
                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron reservas para los apellidos proporcionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Asignar los resultados al DataGridView
                dataGridViewClientsHst.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar reservas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            

            
        }

        private void DateCheckOutHstClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
