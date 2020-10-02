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
            this.groupBoxbtnsReservas = new System.Windows.Forms.GroupBox();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.groupBoxReservaHeader.SuspendLayout();
            this.groupBoxHabitacionesReservadas.SuspendLayout();
            this.groupBoxbtnsReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("PaybAck", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.Location = new System.Drawing.Point(322, 34);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(152, 30);
            this.lblReservas.TabIndex = 0;
            this.lblReservas.Text = "Reservas";
            this.lblReservas.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxReservaHeader
            // 
            this.groupBoxReservaHeader.Controls.Add(this.lblReservas);
            this.groupBoxReservaHeader.Location = new System.Drawing.Point(12, 12);
            this.groupBoxReservaHeader.Name = "groupBoxReservaHeader";
            this.groupBoxReservaHeader.Size = new System.Drawing.Size(776, 100);
            this.groupBoxReservaHeader.TabIndex = 1;
            this.groupBoxReservaHeader.TabStop = false;
            // 
            // groupBoxHabitacionesReservadas
            // 
            this.groupBoxHabitacionesReservadas.Controls.Add(this.listBoxReservas);
            this.groupBoxHabitacionesReservadas.Location = new System.Drawing.Point(12, 118);
            this.groupBoxHabitacionesReservadas.Name = "groupBoxHabitacionesReservadas";
            this.groupBoxHabitacionesReservadas.Size = new System.Drawing.Size(776, 229);
            this.groupBoxHabitacionesReservadas.TabIndex = 2;
            this.groupBoxHabitacionesReservadas.TabStop = false;
            // 
            // groupBoxbtnsReservas
            // 
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckOut);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCheckIn);
            this.groupBoxbtnsReservas.Controls.Add(this.btnCrearReserva);
            this.groupBoxbtnsReservas.Location = new System.Drawing.Point(12, 353);
            this.groupBoxbtnsReservas.Name = "groupBoxbtnsReservas";
            this.groupBoxbtnsReservas.Size = new System.Drawing.Size(776, 127);
            this.groupBoxbtnsReservas.TabIndex = 3;
            this.groupBoxbtnsReservas.TabStop = false;
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCrearReserva.Font = new System.Drawing.Font("PaybAck", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.Location = new System.Drawing.Point(6, 30);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(244, 65);
            this.btnCrearReserva.TabIndex = 0;
            this.btnCrearReserva.Text = "Crear Reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("PaybAck", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(435, 30);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(142, 65);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("PaybAck", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(611, 31);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(142, 65);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(6, 10);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(764, 212);
            this.listBoxReservas.TabIndex = 0;
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
            this.groupBoxReservaHeader.ResumeLayout(false);
            this.groupBoxReservaHeader.PerformLayout();
            this.groupBoxHabitacionesReservadas.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBoxReservas;
    }
}