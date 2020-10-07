namespace Hotel
{
    partial class CrearReserva
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
            this.lblNuevaReserva = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblNumDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnCDalcularDias = new System.Windows.Forms.Button();
            this.groupBoxTitularNuevaReserva = new System.Windows.Forms.GroupBox();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.txtNumID = new System.Windows.Forms.TextBox();
            this.lblNumID = new System.Windows.Forms.Label();
            this.txtNombreTitular = new System.Windows.Forms.TextBox();
            this.lblNombreTitular = new System.Windows.Forms.Label();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumReserva = new System.Windows.Forms.TextBox();
            this.lblNumReserva = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBoxTitularNuevaReserva.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevaReserva
            // 
            this.lblNuevaReserva.AutoSize = true;
            this.lblNuevaReserva.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblNuevaReserva.Location = new System.Drawing.Point(268, 9);
            this.lblNuevaReserva.Name = "lblNuevaReserva";
            this.lblNuevaReserva.Size = new System.Drawing.Size(271, 40);
            this.lblNuevaReserva.TabIndex = 0;
            this.lblNuevaReserva.Text = "Nueva Reserva";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(218, 100);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(218, 146);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 2;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(53, 106);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(113, 16);
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblFechaSalida.Location = new System.Drawing.Point(56, 146);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(88, 16);
            this.lblFechaSalida.TabIndex = 4;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // lblNumDias
            // 
            this.lblNumDias.AutoSize = true;
            this.lblNumDias.Location = new System.Drawing.Point(487, 152);
            this.lblNumDias.Name = "lblNumDias";
            this.lblNumDias.Size = new System.Drawing.Size(30, 13);
            this.lblNumDias.TabIndex = 5;
            this.lblNumDias.Text = "Días";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(535, 149);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 6;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // btnCDalcularDias
            // 
            this.btnCDalcularDias.Location = new System.Drawing.Point(490, 99);
            this.btnCDalcularDias.Name = "btnCDalcularDias";
            this.btnCDalcularDias.Size = new System.Drawing.Size(106, 23);
            this.btnCDalcularDias.TabIndex = 7;
            this.btnCDalcularDias.Text = "Calcular días";
            this.btnCDalcularDias.UseVisualStyleBackColor = true;
            this.btnCDalcularDias.Click += new System.EventHandler(this.btnCDalcularDias_Click);
            // 
            // groupBoxTitularNuevaReserva
            // 
            this.groupBoxTitularNuevaReserva.Controls.Add(this.btnGuardarPersona);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.comboBoxTipoPersona);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.lblTipoPersona);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.txtNumID);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.lblNumID);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.txtNombreTitular);
            this.groupBoxTitularNuevaReserva.Controls.Add(this.lblNombreTitular);
            this.groupBoxTitularNuevaReserva.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBoxTitularNuevaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.groupBoxTitularNuevaReserva.Location = new System.Drawing.Point(59, 208);
            this.groupBoxTitularNuevaReserva.Name = "groupBoxTitularNuevaReserva";
            this.groupBoxTitularNuevaReserva.Size = new System.Drawing.Size(376, 168);
            this.groupBoxTitularNuevaReserva.TabIndex = 8;
            this.groupBoxTitularNuevaReserva.TabStop = false;
            this.groupBoxTitularNuevaReserva.Text = "Titular";
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.btnGuardarPersona.Location = new System.Drawing.Point(159, 139);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(200, 23);
            this.btnGuardarPersona.TabIndex = 6;
            this.btnGuardarPersona.Text = "Guardar titular";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPersona.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Items.AddRange(new object[] {
            "Huesped",
            "Cliente"});
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(159, 93);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipoPersona.TabIndex = 5;
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblTipoPersona.Location = new System.Drawing.Point(10, 93);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(40, 15);
            this.lblTipoPersona.TabIndex = 4;
            this.lblTipoPersona.Text = "Tipo: ";
            // 
            // txtNumID
            // 
            this.txtNumID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.txtNumID.Location = new System.Drawing.Point(159, 53);
            this.txtNumID.MaxLength = 10;
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(200, 23);
            this.txtNumID.TabIndex = 3;
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblNumID.Location = new System.Drawing.Point(6, 59);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(157, 15);
            this.lblNumID.TabIndex = 2;
            this.lblNumID.Text = "Número de identificación: ";
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.txtNombreTitular.Location = new System.Drawing.Point(159, 13);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(200, 23);
            this.txtNombreTitular.TabIndex = 1;
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((int)(0)));
            this.lblNombreTitular.Location = new System.Drawing.Point(7, 26);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(90, 13);
            this.lblNombreTitular.TabIndex = 0;
            this.lblNombreTitular.Text = "Nombre completo";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(490, 221);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(351, 147);
            this.listClientes.TabIndex = 2;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumReserva);
            this.groupBox1.Controls.Add(this.lblNumReserva);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblTipoHabitacion);
            this.groupBox1.Location = new System.Drawing.Point(59, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtNumReserva
            // 
            this.txtNumReserva.Location = new System.Drawing.Point(159, 72);
            this.txtNumReserva.Name = "txtNumReserva";
            this.txtNumReserva.ReadOnly = true;
            this.txtNumReserva.Size = new System.Drawing.Size(200, 20);
            this.txtNumReserva.TabIndex = 3;
            this.txtNumReserva.TextChanged += new System.EventHandler(this.txtNumReserva_TextChanged);
            // 
            // lblNumReserva
            // 
            this.lblNumReserva.AutoSize = true;
            this.lblNumReserva.Location = new System.Drawing.Point(13, 72);
            this.lblNumReserva.Name = "lblNumReserva";
            this.lblNumReserva.Size = new System.Drawing.Size(103, 13);
            this.lblNumReserva.TabIndex = 2;
            this.lblNumReserva.Text = "Número de reserva: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(159, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Location = new System.Drawing.Point(9, 36);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(98, 13);
            this.lblTipoHabitacion.TabIndex = 0;
            this.lblTipoHabitacion.Text = "Tipo de habitación:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(490, 458);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(720, 458);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(121, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // CrearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.groupBoxTitularNuevaReserva);
            this.Controls.Add(this.btnCDalcularDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblNumDias);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblNuevaReserva);
            this.Name = "CrearReserva";
            this.Text = "Crear reserva";
            this.groupBoxTitularNuevaReserva.ResumeLayout(false);
            this.groupBoxTitularNuevaReserva.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblNumDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnCDalcularDias;
        private System.Windows.Forms.GroupBox groupBoxTitularNuevaReserva;
        private System.Windows.Forms.Label lblNombreTitular;
        private System.Windows.Forms.Label lblNumID;
        private System.Windows.Forms.TextBox txtNombreTitular;
        private System.Windows.Forms.TextBox txtNumID;
        private System.Windows.Forms.ComboBox comboBoxTipoPersona;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumReserva;
        private System.Windows.Forms.Label lblNumReserva;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRegresar;
    }
}