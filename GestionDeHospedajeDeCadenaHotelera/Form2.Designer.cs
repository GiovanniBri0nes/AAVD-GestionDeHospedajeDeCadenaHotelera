namespace GestionDeHospedajeDeCadenaHotelera
{
    partial class FrfCheckInCheckOut
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DGVIdClientes = new System.Windows.Forms.DataGridView();
            this.cbIdReservaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaReservacionCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "ChechkOut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGVIdClientes
            // 
            this.DGVIdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIdClientes.Location = new System.Drawing.Point(12, 12);
            this.DGVIdClientes.Name = "DGVIdClientes";
            this.DGVIdClientes.RowHeadersWidth = 51;
            this.DGVIdClientes.RowTemplate.Height = 24;
            this.DGVIdClientes.Size = new System.Drawing.Size(489, 400);
            this.DGVIdClientes.TabIndex = 2;
            // 
            // cbIdReservaciones
            // 
            this.cbIdReservaciones.FormattingEnabled = true;
            this.cbIdReservaciones.Location = new System.Drawing.Point(700, 12);
            this.cbIdReservaciones.Name = "cbIdReservaciones";
            this.cbIdReservaciones.Size = new System.Drawing.Size(376, 24);
            this.cbIdReservaciones.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID RESERVACION:";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(822, 42);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(254, 22);
            this.txtApellidoPaterno.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido:";
            // 
            // btnBuscaReservacionCliente
            // 
            this.btnBuscaReservacionCliente.Location = new System.Drawing.Point(889, 111);
            this.btnBuscaReservacionCliente.Name = "btnBuscaReservacionCliente";
            this.btnBuscaReservacionCliente.Size = new System.Drawing.Size(187, 66);
            this.btnBuscaReservacionCliente.TabIndex = 7;
            this.btnBuscaReservacionCliente.Text = "Buscar Reservaciones por apellido";
            this.btnBuscaReservacionCliente.UseVisualStyleBackColor = true;
            this.btnBuscaReservacionCliente.Click += new System.EventHandler(this.btnBuscaReservacionCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido:";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(822, 70);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(254, 22);
            this.txtApellidoMaterno.TabIndex = 8;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(893, 345);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(187, 66);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrfCheckInCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.btnBuscaReservacionCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoPaterno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIdReservaciones);
            this.Controls.Add(this.DGVIdClientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrfCheckInCheckOut";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DGVIdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGVIdClientes;
        private System.Windows.Forms.ComboBox cbIdReservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaReservacionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Button btnRegresar;
    }
}