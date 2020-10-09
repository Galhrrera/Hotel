namespace Hotel
{
    partial class Reservas
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
            this.lblReservas = new System.Windows.Forms.Label();
            this.groupBoxReservaHeader = new System.Windows.Forms.GroupBox();
            this.groupBoxHabitacionesReservadas = new System.Windows.Forms.GroupBox();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.groupBoxbtnsReservas = new System.Windows.Forms.GroupBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.groupBoxReservaHeader.SuspendLayout();
            this.groupBoxHabitacionesReservadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.groupBoxbtnsReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.Location = new System.Drawing.Point(429, 42);
            this.lblReservas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(185, 42);
            this.lblReservas.TabIndex = 0;
            this.lblReservas.Text = "Reservas";
            // 
            // groupBoxReservaHeader
            // 
            this.groupBoxReservaHeader.Controls.Add(this.lblReservas);
            this.groupBoxReservaHeader.Location = new System.Drawing.Point(16, 15);
            this.groupBoxReservaHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxReservaHeader.Name = "groupBoxReservaHeader";
            this.groupBoxReservaHeader.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxReservaHeader.Size = new System.Drawing.Size(1035, 123);
            this.groupBoxReservaHeader.TabIndex = 1;
            this.groupBoxReservaHeader.TabStop = false;
            this.groupBoxReservaHeader.Enter += new System.EventHandler(this.groupBoxReservaHeader_Enter);
            // 
            // groupBoxHabitacionesReservadas
            // 
            this.groupBoxHabitacionesReservadas.Controls.Add(this.dataGridViewReservas);
            this.groupBoxHabitacionesReservadas.Location = new System.Drawing.Point(16, 145);
            this.groupBoxHabitacionesReservadas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHabitacionesReservadas.Name = "groupBoxHabitacionesReservadas";
            this.groupBoxHabitacionesReservadas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHabitacionesReservadas.Size = new System.Drawing.Size(1035, 282);
            this.groupBoxHabitacionesReservadas.TabIndex = 2;
            this.groupBoxHabitacionesReservadas.TabStop = false;
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AllowUserToDeleteRows = false;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(8, 25);
            this.dataGridViewReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.Size = new System.Drawing.Size(1019, 250);
            this.dataGridViewReservas.TabIndex = 0;
            // 
            // groupBoxbtnsReservas
            // 
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckOut);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckIn);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCrearReserva);
            this.groupBoxbtnsReservas.Location = new System.Drawing.Point(16, 434);
            this.groupBoxbtnsReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxbtnsReservas.Name = "groupBoxbtnsReservas";
            this.groupBoxbtnsReservas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxbtnsReservas.Size = new System.Drawing.Size(1035, 156);
            this.groupBoxbtnsReservas.TabIndex = 3;
            this.groupBoxbtnsReservas.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(815, 38);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(189, 80);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(580, 37);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(189, 80);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.Location = new System.Drawing.Point(8, 37);
            this.btnCrearReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(325, 80);
            this.btnCrearReserva.TabIndex = 0;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 606);
            this.Controls.Add(this.groupBoxbtnsReservas);
            this.Controls.Add(this.groupBoxHabitacionesReservadas);
            this.Controls.Add(this.groupBoxReservaHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.groupBoxReservaHeader.ResumeLayout(false);
            this.groupBoxReservaHeader.PerformLayout();
            this.groupBoxHabitacionesReservadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.groupBoxbtnsReservas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.GroupBox groupBoxReservaHeader;
        private System.Windows.Forms.GroupBox groupBoxHabitacionesReservadas;
        private System.Windows.Forms.GroupBox groupBoxbtnsReservas;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
    }
}