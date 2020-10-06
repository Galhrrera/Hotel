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
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.dataGridViewHabitaciones = new System.Windows.Forms.DataGridView();
            this.CoumnaPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarHabitaciones
            // 
            this.btnRegresarHabitaciones.Location = new System.Drawing.Point(374, 405);
            this.btnRegresarHabitaciones.Name = "btnRegresarHabitaciones";
            this.btnRegresarHabitaciones.Size = new System.Drawing.Size(138, 33);
            this.btnRegresarHabitaciones.TabIndex = 0;
            this.btnRegresarHabitaciones.Text = "Regresar";
            this.btnRegresarHabitaciones.UseVisualStyleBackColor = true;
            this.btnRegresarHabitaciones.Click += new System.EventHandler(this.btnRegresarHabitaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHabitaciones);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxListaHabitaciones";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("PaybAck", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(153, 19);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(218, 34);
            this.lblHabitaciones.TabIndex = 2;
            this.lblHabitaciones.Text = "Habitaciones";
            this.lblHabitaciones.Click += new System.EventHandler(this.lblHabitaciones_Click);
            // 
            // dataGridViewHabitaciones
            // 
            this.dataGridViewHabitaciones.AllowUserToOrderColumns = true;
            this.dataGridViewHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoumnaPiso,
            this.ColumnaNumHabitacion,
            this.ColumnEstado});
            this.dataGridViewHabitaciones.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewHabitaciones.Name = "dataGridViewHabitaciones";
            this.dataGridViewHabitaciones.Size = new System.Drawing.Size(493, 232);
            this.dataGridViewHabitaciones.TabIndex = 0;
            this.dataGridViewHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CoumnaPiso
            // 
            this.CoumnaPiso.Frozen = true;
            this.CoumnaPiso.HeaderText = "Piso";
            this.CoumnaPiso.Name = "CoumnaPiso";
            // 
            // ColumnaNumHabitacion
            // 
            this.ColumnaNumHabitacion.Frozen = true;
            this.ColumnaNumHabitacion.HeaderText = "Número de habitación";
            this.ColumnaNumHabitacion.Name = "ColumnaNumHabitacion";
            this.ColumnaNumHabitacion.Width = 150;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.Frozen = true;
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Width = 200;
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarHabitaciones);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dataGridViewHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoumnaPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
    }
}