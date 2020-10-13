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
            this.button_regresar = new System.Windows.Forms.Button();
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
            this.lblReservas.Location = new System.Drawing.Point(322, 34);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(147, 33);
            this.lblReservas.TabIndex = 0;
            this.lblReservas.Text = "Reservas";
            // 
            // groupBoxReservaHeader
            // 
            this.groupBoxReservaHeader.Controls.Add(this.lblReservas);
            this.groupBoxReservaHeader.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReservaHeader.Name = "groupBoxReservaHeader";
            this.groupBoxReservaHeader.Size = new System.Drawing.Size(776, 100);
            this.groupBoxReservaHeader.TabIndex = 1;
            this.groupBoxReservaHeader.TabStop = false;
            this.groupBoxReservaHeader.Enter += new System.EventHandler(this.groupBoxReservaHeader_Enter);
            // 
            // groupBoxHabitacionesReservadas
            // 
            this.groupBoxHabitacionesReservadas.Controls.Add(this.dataGridViewReservas);
            this.groupBoxHabitacionesReservadas.Location = new System.Drawing.Point(12, 118);
            this.groupBoxHabitacionesReservadas.Name = "groupBoxHabitacionesReservadas";
            this.groupBoxHabitacionesReservadas.Size = new System.Drawing.Size(776, 229);
            this.groupBoxHabitacionesReservadas.TabIndex = 2;
            this.groupBoxHabitacionesReservadas.TabStop = false;
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.AllowUserToAddRows = false;
            this.dataGridViewReservas.AllowUserToDeleteRows = false;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.ReadOnly = true;
            this.dataGridViewReservas.RowHeadersWidth = 51;
            this.dataGridViewReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservas.Size = new System.Drawing.Size(764, 203);
            this.dataGridViewReservas.TabIndex = 0;
            this.dataGridViewReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservas_CellContentClick);
            // 
            // groupBoxbtnsReservas
            // 
            this.groupBoxbtnsReservas.Controls.Add(this.button_regresar);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckOut);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckIn);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCrearReserva);
            this.groupBoxbtnsReservas.Location = new System.Drawing.Point(12, 353);
            this.groupBoxbtnsReservas.Name = "groupBoxbtnsReservas";
            this.groupBoxbtnsReservas.Size = new System.Drawing.Size(776, 127);
            this.groupBoxbtnsReservas.TabIndex = 3;
            this.groupBoxbtnsReservas.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(328, 77);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(124, 44);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(328, 19);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(124, 45);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCrearReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.Location = new System.Drawing.Point(6, 30);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(244, 65);
            this.btnCrearReserva.TabIndex = 0;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.Color.Magenta;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.Location = new System.Drawing.Point(526, 30);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(244, 65);
            this.button_regresar.TabIndex = 3;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.groupBoxbtnsReservas);
            this.Controls.Add(this.groupBoxHabitacionesReservadas);
            this.Controls.Add(this.groupBoxReservaHeader);
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
        private System.Windows.Forms.Button button_regresar;
    }
}