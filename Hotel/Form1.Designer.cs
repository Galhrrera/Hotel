namespace Hotel
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblNombreHotel = new System.Windows.Forms.Label();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.foto_hotel = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreHotel
            // 
            this.lblNombreHotel.AutoSize = true;
            this.lblNombreHotel.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblNombreHotel.Location = new System.Drawing.Point(424, -6);
            this.lblNombreHotel.Name = "lblNombreHotel";
            this.lblNombreHotel.Size = new System.Drawing.Size(452, 114);
            this.lblNombreHotel.TabIndex = 3;
            this.lblNombreHotel.Text = "Maleni Resort";
            this.lblNombreHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.btnReservas.Location = new System.Drawing.Point(60, 130);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(241, 109);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.LightBlue;
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.btnHabitaciones.Location = new System.Drawing.Point(60, 308);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(241, 109);
            this.btnHabitaciones.TabIndex = 2;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((int)(128)))), ((int)(((int)(255)))), ((int)(((int)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.btnExit.Location = new System.Drawing.Point(60, 485);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 109);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // foto_hotel
            // 
            this.foto_hotel.Image = ((System.Drawing.Image)(resources.GetObject("foto_hotel.Image")));
            this.foto_hotel.Location = new System.Drawing.Point(407, 102);
            this.foto_hotel.Name = "foto_hotel";
            this.foto_hotel.Size = new System.Drawing.Size(500, 350);
            this.foto_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.foto_hotel.TabIndex = 4;
            this.foto_hotel.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(391, 458);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(568, 169);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 638);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.foto_hotel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.lblNombreHotel);
            this.Name = "Principal";
            this.Text = "Sistema de reservas del hotel";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreHotel;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox foto_hotel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

