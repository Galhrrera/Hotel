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
            this.dataGridViewHabitaciones = new System.Windows.Forms.DataGridView();
            this.CoumnaPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarHabitaciones
            // 
            this.btnRegresarHabitaciones.Location = new System.Drawing.Point(499, 498);
            this.btnRegresarHabitaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresarHabitaciones.Name = "btnRegresarHabitaciones";
            this.btnRegresarHabitaciones.Size = new System.Drawing.Size(184, 41);
            this.btnRegresarHabitaciones.TabIndex = 0;
            this.btnRegresarHabitaciones.Text = "Regresar";
            this.btnRegresarHabitaciones.UseVisualStyleBackColor = true;
            this.btnRegresarHabitaciones.Click += new System.EventHandler(this.btnRegresarHabitaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHabitaciones);
            this.groupBox1.Location = new System.Drawing.Point(17, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(681, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxListaHabitaciones";
            // 
            // dataGridViewHabitaciones
            // 
            this.dataGridViewHabitaciones.AllowUserToOrderColumns = true;
            this.dataGridViewHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoumnaPiso,
            this.ColumnaNumHabitacion,
            this.ColumnEstado});
            this.dataGridViewHabitaciones.Location = new System.Drawing.Point(8, 23);
            this.dataGridViewHabitaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewHabitaciones.Name = "dataGridViewHabitaciones";
            this.dataGridViewHabitaciones.RowHeadersWidth = 51;
            this.dataGridViewHabitaciones.Size = new System.Drawing.Size(657, 286);
            this.dataGridViewHabitaciones.TabIndex = 0;
            this.dataGridViewHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CoumnaPiso
            // 
            this.CoumnaPiso.Frozen = true;
            this.CoumnaPiso.HeaderText = "Piso";
            this.CoumnaPiso.MinimumWidth = 6;
            this.CoumnaPiso.Name = "CoumnaPiso";
            this.CoumnaPiso.Width = 125;
            // 
            // ColumnaNumHabitacion
            // 
            this.ColumnaNumHabitacion.Frozen = true;
            this.ColumnaNumHabitacion.HeaderText = "Número de habitación";
            this.ColumnaNumHabitacion.MinimumWidth = 6;
            this.ColumnaNumHabitacion.Name = "ColumnaNumHabitacion";
            this.ColumnaNumHabitacion.Width = 150;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.Frozen = true;
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Width = 200;
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(204, 23);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(252, 46);
            this.lblHabitaciones.TabIndex = 2;
            this.lblHabitaciones.Text = "Habitaciones";
            this.lblHabitaciones.Click += new System.EventHandler(this.lblHabitaciones_Click);
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 554);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresarHabitaciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.Habitaciones_Load);
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