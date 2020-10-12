namespace Hotel
{
    partial class Servicios_xHabitación
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
            this.titulo_servicioshab = new System.Windows.Forms.Label();
            this.num_habitacion = new System.Windows.Forms.Label();
            this.restaurante_menu = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lista_restaurante = new System.Windows.Forms.Label();
            this.lista_lavanderia = new System.Windows.Forms.Label();
            this.txtCantPrendas = new System.Windows.Forms.TextBox();
            this.cant_prendas = new System.Windows.Forms.Label();
            this.subtotal_restaurante = new System.Windows.Forms.Label();
            this.subtotal_lavanderia = new System.Windows.Forms.Label();
            this.solicitar_servicio = new System.Windows.Forms.Button();
            this.regresar_habitacion = new System.Windows.Forms.Button();
            this.cant_platos = new System.Windows.Forms.Label();
            this.txtCantPlatos = new System.Windows.Forms.TextBox();
            this.lblRS = new System.Windows.Forms.Label();
            this.cBroomService = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titulo_servicioshab
            // 
            this.titulo_servicioshab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo_servicioshab.AutoSize = true;
            this.titulo_servicioshab.Font = new System.Drawing.Font("Sitka Banner", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_servicioshab.Location = new System.Drawing.Point(317, 11);
            this.titulo_servicioshab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_servicioshab.Name = "titulo_servicioshab";
            this.titulo_servicioshab.Size = new System.Drawing.Size(424, 68);
            this.titulo_servicioshab.TabIndex = 0;
            this.titulo_servicioshab.Text = "Servicios Habitación";
            this.titulo_servicioshab.Click += new System.EventHandler(this.label1_Click);
            // 
            // num_habitacion
            // 
            this.num_habitacion.AutoSize = true;
            this.num_habitacion.Location = new System.Drawing.Point(491, 27);
            this.num_habitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.num_habitacion.Name = "num_habitacion";
            this.num_habitacion.Size = new System.Drawing.Size(0, 17);
            this.num_habitacion.TabIndex = 1;
            // 
            // restaurante_menu
            // 
            this.restaurante_menu.CheckOnClick = true;
            this.restaurante_menu.FormattingEnabled = true;
            this.restaurante_menu.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Cena"});
            this.restaurante_menu.Location = new System.Drawing.Point(53, 142);
            this.restaurante_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restaurante_menu.Name = "restaurante_menu";
            this.restaurante_menu.Size = new System.Drawing.Size(395, 123);
            this.restaurante_menu.TabIndex = 2;
            this.restaurante_menu.SelectedIndexChanged += new System.EventHandler(this.restaurante_menu_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Lavar",
            "Planchar"});
            this.checkedListBox1.Location = new System.Drawing.Point(620, 142);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(387, 123);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lista_restaurante
            // 
            this.lista_restaurante.AutoSize = true;
            this.lista_restaurante.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_restaurante.Location = new System.Drawing.Point(48, 107);
            this.lista_restaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lista_restaurante.Name = "lista_restaurante";
            this.lista_restaurante.Size = new System.Drawing.Size(146, 26);
            this.lista_restaurante.TabIndex = 5;
            this.lista_restaurante.Text = "Restaurante";
            this.lista_restaurante.Click += new System.EventHandler(this.lista_restaurante_Click);
            // 
            // lista_lavanderia
            // 
            this.lista_lavanderia.AutoSize = true;
            this.lista_lavanderia.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_lavanderia.Location = new System.Drawing.Point(615, 107);
            this.lista_lavanderia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lista_lavanderia.Name = "lista_lavanderia";
            this.lista_lavanderia.Size = new System.Drawing.Size(133, 26);
            this.lista_lavanderia.TabIndex = 6;
            this.lista_lavanderia.Text = "Lavandería";
            // 
            // txtCantPrendas
            // 
            this.txtCantPrendas.Location = new System.Drawing.Point(768, 308);
            this.txtCantPrendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantPrendas.Name = "txtCantPrendas";
            this.txtCantPrendas.Size = new System.Drawing.Size(132, 22);
            this.txtCantPrendas.TabIndex = 7;
            // 
            // cant_prendas
            // 
            this.cant_prendas.AutoSize = true;
            this.cant_prendas.Location = new System.Drawing.Point(616, 311);
            this.cant_prendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cant_prendas.Name = "cant_prendas";
            this.cant_prendas.Size = new System.Drawing.Size(144, 17);
            this.cant_prendas.TabIndex = 8;
            this.cant_prendas.Text = "Cantidad de prendas:";
            // 
            // subtotal_restaurante
            // 
            this.subtotal_restaurante.AutoSize = true;
            this.subtotal_restaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_restaurante.Location = new System.Drawing.Point(49, 372);
            this.subtotal_restaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotal_restaurante.Name = "subtotal_restaurante";
            this.subtotal_restaurante.Size = new System.Drawing.Size(172, 17);
            this.subtotal_restaurante.TabIndex = 9;
            this.subtotal_restaurante.Text = "Subtotal Restaurante: ";
            // 
            // subtotal_lavanderia
            // 
            this.subtotal_lavanderia.AutoSize = true;
            this.subtotal_lavanderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_lavanderia.Location = new System.Drawing.Point(616, 372);
            this.subtotal_lavanderia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtotal_lavanderia.Name = "subtotal_lavanderia";
            this.subtotal_lavanderia.Size = new System.Drawing.Size(164, 17);
            this.subtotal_lavanderia.TabIndex = 10;
            this.subtotal_lavanderia.Text = "Subtotal Lavandería: ";
            this.subtotal_lavanderia.Click += new System.EventHandler(this.subtotal_lavanderia_Click);
            // 
            // solicitar_servicio
            // 
            this.solicitar_servicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solicitar_servicio.Location = new System.Drawing.Point(300, 444);
            this.solicitar_servicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.solicitar_servicio.Name = "solicitar_servicio";
            this.solicitar_servicio.Size = new System.Drawing.Size(191, 69);
            this.solicitar_servicio.TabIndex = 11;
            this.solicitar_servicio.Text = "Solicitar";
            this.solicitar_servicio.UseVisualStyleBackColor = true;
            this.solicitar_servicio.Click += new System.EventHandler(this.solicitar_servicio_Click);
            // 
            // regresar_habitacion
            // 
            this.regresar_habitacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar_habitacion.Location = new System.Drawing.Point(527, 444);
            this.regresar_habitacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regresar_habitacion.Name = "regresar_habitacion";
            this.regresar_habitacion.Size = new System.Drawing.Size(175, 69);
            this.regresar_habitacion.TabIndex = 12;
            this.regresar_habitacion.Text = "Regresar";
            this.regresar_habitacion.UseVisualStyleBackColor = true;
            this.regresar_habitacion.Click += new System.EventHandler(this.regresar_habitacion_Click);
            // 
            // cant_platos
            // 
            this.cant_platos.AutoSize = true;
            this.cant_platos.Location = new System.Drawing.Point(49, 288);
            this.cant_platos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cant_platos.Name = "cant_platos";
            this.cant_platos.Size = new System.Drawing.Size(130, 17);
            this.cant_platos.TabIndex = 13;
            this.cant_platos.Text = "Cantidad de platos:";
            // 
            // txtCantPlatos
            // 
            this.txtCantPlatos.Location = new System.Drawing.Point(187, 288);
            this.txtCantPlatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantPlatos.Name = "txtCantPlatos";
            this.txtCantPlatos.Size = new System.Drawing.Size(132, 22);
            this.txtCantPlatos.TabIndex = 14;
            this.txtCantPlatos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtCantPlatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Location = new System.Drawing.Point(53, 332);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(100, 17);
            this.lblRS.TabIndex = 15;
            this.lblRS.Text = "Room Service:";
            // 
            // cBroomService
            // 
            this.cBroomService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBroomService.FormattingEnabled = true;
            this.cBroomService.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cBroomService.Location = new System.Drawing.Point(187, 323);
            this.cBroomService.Name = "cBroomService";
            this.cBroomService.Size = new System.Drawing.Size(132, 24);
            this.cBroomService.TabIndex = 16;
            // 
            // Servicios_xHabitación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cBroomService);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.txtCantPlatos);
            this.Controls.Add(this.cant_platos);
            this.Controls.Add(this.regresar_habitacion);
            this.Controls.Add(this.solicitar_servicio);
            this.Controls.Add(this.subtotal_lavanderia);
            this.Controls.Add(this.subtotal_restaurante);
            this.Controls.Add(this.cant_prendas);
            this.Controls.Add(this.txtCantPrendas);
            this.Controls.Add(this.lista_lavanderia);
            this.Controls.Add(this.lista_restaurante);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.restaurante_menu);
            this.Controls.Add(this.num_habitacion);
            this.Controls.Add(this.titulo_servicioshab);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Servicios_xHabitación";
            this.Text = "Servicios_xHabitación";
            this.Load += new System.EventHandler(this.Servicios_xHabitación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_servicioshab;
        private System.Windows.Forms.Label num_habitacion;
        private System.Windows.Forms.CheckedListBox restaurante_menu;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lista_restaurante;
        private System.Windows.Forms.Label lista_lavanderia;
        private System.Windows.Forms.TextBox txtCantPrendas;
        private System.Windows.Forms.Label cant_prendas;
        private System.Windows.Forms.Label subtotal_restaurante;
        private System.Windows.Forms.Label subtotal_lavanderia;
        private System.Windows.Forms.Button solicitar_servicio;
        private System.Windows.Forms.Button regresar_habitacion;
        private System.Windows.Forms.Label cant_platos;
        private System.Windows.Forms.TextBox txtCantPlatos;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.ComboBox cBroomService;
    }
}