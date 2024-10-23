namespace GestionDeHospedajeDeCadenaHotelera
{
    partial class HistorialCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.textApellidoPaterno = new System.Windows.Forms.TextBox();
            this.dataGridViewClientsHst = new System.Windows.Forms.DataGridView();
            this.buttonBuscarHistorialClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientsHst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido Paterno:";
            // 
            // textApellidoPaterno
            // 
            this.textApellidoPaterno.Location = new System.Drawing.Point(270, 50);
            this.textApellidoPaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textApellidoPaterno.Name = "textApellidoPaterno";
            this.textApellidoPaterno.Size = new System.Drawing.Size(301, 22);
            this.textApellidoPaterno.TabIndex = 2;
            this.textApellidoPaterno.TextChanged += new System.EventHandler(this.textBoxBuscarC_TextChanged);
            // 
            // dataGridViewClientsHst
            // 
            this.dataGridViewClientsHst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientsHst.Location = new System.Drawing.Point(12, 191);
            this.dataGridViewClientsHst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClientsHst.Name = "dataGridViewClientsHst";
            this.dataGridViewClientsHst.RowHeadersWidth = 51;
            this.dataGridViewClientsHst.RowTemplate.Height = 24;
            this.dataGridViewClientsHst.Size = new System.Drawing.Size(1456, 331);
            this.dataGridViewClientsHst.TabIndex = 3;
            // 
            // buttonBuscarHistorialClient
            // 
            this.buttonBuscarHistorialClient.Location = new System.Drawing.Point(641, 113);
            this.buttonBuscarHistorialClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarHistorialClient.Name = "buttonBuscarHistorialClient";
            this.buttonBuscarHistorialClient.Size = new System.Drawing.Size(140, 37);
            this.buttonBuscarHistorialClient.TabIndex = 6;
            this.buttonBuscarHistorialClient.Text = "Buscar Historial";
            this.buttonBuscarHistorialClient.UseVisualStyleBackColor = true;
            this.buttonBuscarHistorialClient.Click += new System.EventHandler(this.buttonBuscarHistorialClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1128, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1267, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(270, 128);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(301, 22);
            this.txtApellidoMaterno.TabIndex = 42;
            this.txtApellidoMaterno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Apellido Materno:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1505, 656);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBuscarHistorialClient);
            this.Controls.Add(this.dataGridViewClientsHst);
            this.Controls.Add(this.textApellidoPaterno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HistorialCliente";
            this.Text = "HistorialCliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientsHst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textApellidoPaterno;
        private System.Windows.Forms.DataGridView dataGridViewClientsHst;
        private System.Windows.Forms.Button buttonBuscarHistorialClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label2;
    }
}