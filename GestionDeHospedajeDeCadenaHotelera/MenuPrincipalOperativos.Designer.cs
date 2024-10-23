namespace GestionDeHospedajeDeCadenaHotelera
{
    partial class MenuPrincipalOperativos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalOperativos));
            this.ButtonReservaciones = new System.Windows.Forms.Button();
            this.buttonGestionClientes = new System.Windows.Forms.Button();
            this.buttonHistorialOpert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReservaciones
            // 
            this.ButtonReservaciones.Location = new System.Drawing.Point(325, 126);
            this.ButtonReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReservaciones.Name = "ButtonReservaciones";
            this.ButtonReservaciones.Size = new System.Drawing.Size(179, 76);
            this.ButtonReservaciones.TabIndex = 0;
            this.ButtonReservaciones.Text = "Reservaciones";
            this.ButtonReservaciones.UseVisualStyleBackColor = true;
            this.ButtonReservaciones.Click += new System.EventHandler(this.ButtonReservaciones_Click);
            // 
            // buttonGestionClientes
            // 
            this.buttonGestionClientes.Location = new System.Drawing.Point(325, 220);
            this.buttonGestionClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestionClientes.Name = "buttonGestionClientes";
            this.buttonGestionClientes.Size = new System.Drawing.Size(179, 68);
            this.buttonGestionClientes.TabIndex = 1;
            this.buttonGestionClientes.Text = "Gestion De Clientes";
            this.buttonGestionClientes.UseVisualStyleBackColor = true;
            this.buttonGestionClientes.Click += new System.EventHandler(this.buttonGestionClientes_Click);
            // 
            // buttonHistorialOpert
            // 
            this.buttonHistorialOpert.Location = new System.Drawing.Point(325, 314);
            this.buttonHistorialOpert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHistorialOpert.Name = "buttonHistorialOpert";
            this.buttonHistorialOpert.Size = new System.Drawing.Size(179, 62);
            this.buttonHistorialOpert.TabIndex = 2;
            this.buttonHistorialOpert.Text = "Historial";
            this.buttonHistorialOpert.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(641, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(510, 314);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(179, 62);
            this.btnCheckIn.TabIndex = 43;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(140, 314);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(179, 62);
            this.btnCerrarSesion.TabIndex = 42;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MenuPrincipalOperativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(859, 406);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHistorialOpert);
            this.Controls.Add(this.buttonGestionClientes);
            this.Controls.Add(this.ButtonReservaciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuPrincipalOperativos";
            this.Text = "MenuPrincipalOperativos";
            this.Load += new System.EventHandler(this.MenuPrincipalOperativos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonReservaciones;
        private System.Windows.Forms.Button buttonGestionClientes;
        private System.Windows.Forms.Button buttonHistorialOpert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}