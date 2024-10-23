namespace GestionDeHospedajeDeCadenaHotelera
{
    partial class ReportesSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesSistema));
            this.buttonRpOcpHotel = new System.Windows.Forms.Button();
            this.buttonRptVentasRpSISTEMA = new System.Windows.Forms.Button();
            this.buttonRegresarReportSistema = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRpOcpHotel
            // 
            this.buttonRpOcpHotel.Location = new System.Drawing.Point(79, 138);
            this.buttonRpOcpHotel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRpOcpHotel.Name = "buttonRpOcpHotel";
            this.buttonRpOcpHotel.Size = new System.Drawing.Size(171, 79);
            this.buttonRpOcpHotel.TabIndex = 0;
            this.buttonRpOcpHotel.Text = "Reporte De Ocupacion Por Hotel";
            this.buttonRpOcpHotel.UseVisualStyleBackColor = true;
            this.buttonRpOcpHotel.Click += new System.EventHandler(this.buttonRpOcpHotel_Click);
            // 
            // buttonRptVentasRpSISTEMA
            // 
            this.buttonRptVentasRpSISTEMA.Location = new System.Drawing.Point(317, 138);
            this.buttonRptVentasRpSISTEMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRptVentasRpSISTEMA.Name = "buttonRptVentasRpSISTEMA";
            this.buttonRptVentasRpSISTEMA.Size = new System.Drawing.Size(156, 79);
            this.buttonRptVentasRpSISTEMA.TabIndex = 1;
            this.buttonRptVentasRpSISTEMA.Text = "ReporteDe Ventas";
            this.buttonRptVentasRpSISTEMA.UseVisualStyleBackColor = true;
            this.buttonRptVentasRpSISTEMA.Click += new System.EventHandler(this.buttonRptVentasRpSISTEMA_Click);
            // 
            // buttonRegresarReportSistema
            // 
            this.buttonRegresarReportSistema.Location = new System.Drawing.Point(218, 261);
            this.buttonRegresarReportSistema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegresarReportSistema.Name = "buttonRegresarReportSistema";
            this.buttonRegresarReportSistema.Size = new System.Drawing.Size(118, 54);
            this.buttonRegresarReportSistema.TabIndex = 2;
            this.buttonRegresarReportSistema.Text = "Regresar";
            this.buttonRegresarReportSistema.UseVisualStyleBackColor = true;
            this.buttonRegresarReportSistema.Click += new System.EventHandler(this.buttonRegresarReportSistema_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(416, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // ReportesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 398);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegresarReportSistema);
            this.Controls.Add(this.buttonRptVentasRpSISTEMA);
            this.Controls.Add(this.buttonRpOcpHotel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportesSistema";
            this.Text = "ReportesSistema";
            this.Load += new System.EventHandler(this.ReportesSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRpOcpHotel;
        private System.Windows.Forms.Button buttonRptVentasRpSISTEMA;
        private System.Windows.Forms.Button buttonRegresarReportSistema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}