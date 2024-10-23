namespace GestionDeHospedajeDeCadenaHotelera
{
    partial class Cancelaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancelaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptarCancelaciones = new System.Windows.Forms.Button();
            this.buttonRegresarCancelaciones = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbCodigoReservacion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargarReservacionesCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Reservacion:";
            // 
            // buttonAceptarCancelaciones
            // 
            this.buttonAceptarCancelaciones.Location = new System.Drawing.Point(682, 350);
            this.buttonAceptarCancelaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptarCancelaciones.Name = "buttonAceptarCancelaciones";
            this.buttonAceptarCancelaciones.Size = new System.Drawing.Size(112, 64);
            this.buttonAceptarCancelaciones.TabIndex = 3;
            this.buttonAceptarCancelaciones.Text = "Aceptar  Cancelacion";
            this.buttonAceptarCancelaciones.UseVisualStyleBackColor = true;
            this.buttonAceptarCancelaciones.Click += new System.EventHandler(this.buttonAceptarCancelaciones_Click);
            // 
            // buttonRegresarCancelaciones
            // 
            this.buttonRegresarCancelaciones.Location = new System.Drawing.Point(918, 350);
            this.buttonRegresarCancelaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegresarCancelaciones.Name = "buttonRegresarCancelaciones";
            this.buttonRegresarCancelaciones.Size = new System.Drawing.Size(112, 64);
            this.buttonRegresarCancelaciones.TabIndex = 4;
            this.buttonRegresarCancelaciones.Text = "Regresar";
            this.buttonRegresarCancelaciones.UseVisualStyleBackColor = true;
            this.buttonRegresarCancelaciones.Click += new System.EventHandler(this.buttonRegresarCancelaciones_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(721, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 34);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(717, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo de Cancelacion:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(227, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // cbCodigoReservacion
            // 
            this.cbCodigoReservacion.FormattingEnabled = true;
            this.cbCodigoReservacion.Location = new System.Drawing.Point(721, 45);
            this.cbCodigoReservacion.Name = "cbCodigoReservacion";
            this.cbCodigoReservacion.Size = new System.Drawing.Size(269, 24);
            this.cbCodigoReservacion.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(646, 244);
            this.dataGridView1.TabIndex = 13;
            // 
            // btnCargarReservacionesCliente
            // 
            this.btnCargarReservacionesCliente.Location = new System.Drawing.Point(800, 350);
            this.btnCargarReservacionesCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarReservacionesCliente.Name = "btnCargarReservacionesCliente";
            this.btnCargarReservacionesCliente.Size = new System.Drawing.Size(112, 64);
            this.btnCargarReservacionesCliente.TabIndex = 14;
            this.btnCargarReservacionesCliente.Text = "CargarReservaciones por apellidos";
            this.btnCargarReservacionesCliente.UseVisualStyleBackColor = true;
            this.btnCargarReservacionesCliente.Click += new System.EventHandler(this.btnCargarReservacionesCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(717, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(721, 218);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaterno.Multiline = true;
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(335, 34);
            this.txtApellidoPaterno.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(717, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pallido materno:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(721, 303);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Multiline = true;
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(335, 34);
            this.txtApellidoMaterno.TabIndex = 17;
            // 
            // Cancelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1069, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.btnCargarReservacionesCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCodigoReservacion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRegresarCancelaciones);
            this.Controls.Add(this.buttonAceptarCancelaciones);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cancelaciones";
            this.Text = "Cancelaciones";
            this.Load += new System.EventHandler(this.Cancelaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptarCancelaciones;
        private System.Windows.Forms.Button buttonRegresarCancelaciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbCodigoReservacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargarReservacionesCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
    }
}