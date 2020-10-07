namespace Hotel
{
    partial class Habitaciones
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
            this.btnRegresarHabitaciones = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaDeHabitaciones = new System.Windows.Forms.DataGridView();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarHabitaciones
            // 
            this.btnRegresarHabitaciones.Location = new System.Drawing.Point(283, 372);
            this.btnRegresarHabitaciones.Name = "btnRegresarHabitaciones";
            this.btnRegresarHabitaciones.Size = new System.Drawing.Size(138, 33);
            this.btnRegresarHabitaciones.TabIndex = 0;
            this.btnRegresarHabitaciones.Text = "Regresar";
            this.btnRegresarHabitaciones.UseVisualStyleBackColor = true;
            this.btnRegresarHabitaciones.Click += new System.EventHandler(this.btnRegresarHabitaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewListaDeHabitaciones);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxListaHabitaciones";
            // 
            // dataGridViewListaDeHabitaciones
            // 
            this.dataGridViewListaDeHabitaciones.AllowUserToAddRows = false;
            this.dataGridViewListaDeHabitaciones.AllowUserToDeleteRows = false;
            this.dataGridViewListaDeHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeHabitaciones.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewListaDeHabitaciones.Name = "dataGridViewListaDeHabitaciones";
            this.dataGridViewListaDeHabitaciones.ReadOnly = true;
            this.dataGridViewListaDeHabitaciones.Size = new System.Drawing.Size(658, 231);
            this.dataGridViewListaDeHabitaciones.TabIndex = 0;
            this.dataGridViewListaDeHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaDeHabitaciones_CellContentClick);
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(254, 26);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(202, 37);
            this.lblHabitaciones.TabIndex = 2;
            this.lblHabitaciones.Text = "Habitaciones";
            this.lblHabitaciones.Click += new System.EventHandler(this.lblHabitaciones_Click);
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarHabitaciones);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.Habitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dataGridViewListaDeHabitaciones;
    }
}