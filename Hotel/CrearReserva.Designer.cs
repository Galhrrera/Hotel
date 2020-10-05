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
            this.groupBoxTitularNuevaReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNuevaReserva
            // 
            this.lblNuevaReserva.AutoSize = true;
            this.lblNuevaReserva.Font = new System.Drawing.Font("PaybAck", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaReserva.Location = new System.Drawing.Point(268, 9);
            this.lblNuevaReserva.Name = "lblNuevaReserva";
            this.lblNuevaReserva.Size = new System.Drawing.Size(259, 34);
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
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(53, 106);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(113, 16);
            this.lblFechaIngreso.TabIndex = 3;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBoxTitularNuevaReserva.Font = new System.Drawing.Font("PaybAck", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitularNuevaReserva.Location = new System.Drawing.Point(59, 208);
            this.groupBoxTitularNuevaReserva.Name = "groupBoxTitularNuevaReserva";
            this.groupBoxTitularNuevaReserva.Size = new System.Drawing.Size(376, 168);
            this.groupBoxTitularNuevaReserva.TabIndex = 8;
            this.groupBoxTitularNuevaReserva.TabStop = false;
            this.groupBoxTitularNuevaReserva.Text = "Titular";
            // 
            // btnGuardarPersona
            // 
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
            this.comboBoxTipoPersona.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Items.AddRange(new object[] {
            "Huesped",
            "Cliente"});
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(159, 93);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(200, 24);
            this.comboBoxTipoPersona.TabIndex = 5;
            this.comboBoxTipoPersona.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPersona_SelectedIndexChanged);
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPersona.Location = new System.Drawing.Point(10, 93);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(40, 15);
            this.lblTipoPersona.TabIndex = 4;
            this.lblTipoPersona.Text = "Tipo: ";
            // 
            // txtNumID
            // 
            this.txtNumID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumID.Location = new System.Drawing.Point(159, 53);
            this.txtNumID.MaxLength = 10;
            this.txtNumID.Name = "txtNumID";
            this.txtNumID.Size = new System.Drawing.Size(200, 23);
            this.txtNumID.TabIndex = 3;
            // 
            // lblNumID
            // 
            this.lblNumID.AutoSize = true;
            this.lblNumID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumID.Location = new System.Drawing.Point(6, 59);
            this.lblNumID.Name = "lblNumID";
            this.lblNumID.Size = new System.Drawing.Size(157, 15);
            this.lblNumID.TabIndex = 2;
            this.lblNumID.Text = "Número de identificación: ";
            // 
            // txtNombreTitular
            // 
            this.txtNombreTitular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTitular.Location = new System.Drawing.Point(159, 13);
            this.txtNombreTitular.Name = "txtNombreTitular";
            this.txtNombreTitular.Size = new System.Drawing.Size(200, 23);
            this.txtNombreTitular.TabIndex = 1;
            // 
            // lblNombreTitular
            // 
            this.lblNombreTitular.AutoSize = true;
            this.lblNombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTitular.Location = new System.Drawing.Point(7, 26);
            this.lblNombreTitular.Name = "lblNombreTitular";
            this.lblNombreTitular.Size = new System.Drawing.Size(90, 13);
            this.lblNombreTitular.TabIndex = 0;
            this.lblNombreTitular.Text = "Nombre completo";
            this.lblNombreTitular.Click += new System.EventHandler(this.label1_Click);
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
            // CrearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 595);
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
    }
}