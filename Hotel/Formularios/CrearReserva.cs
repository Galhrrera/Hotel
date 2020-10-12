using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel
{
    public partial class CrearReserva : Form
    {
        private List<Persona> listatemp = new List<Persona>();
        private Persona personaTemp;

        private int dias;

        public int Dias { get => dias; set => dias = value; }

        public CrearReserva(List<Persona> lista)
        {
            InitializeComponent();

            if (lista != null)
                listatemp = lista;
            else
                listatemp = new List<Persona>();
            
            LlenarListaPersonas(listatemp);
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCDalcularDias_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = dtpFechaIngreso.Value.Date;
            DateTime fechaSalida = dtpFechaSalida.Value.Date;   //dtpFechaEntrada & dtpFechaSalida son los nombres de los box en el formulario

            TimeSpan tSpan = fechaSalida - fechaEntrada;

            dias = tSpan.Days;


            if (dias <= 0 || dias == null)
            {
                MessageBox.Show("Por favor revise las fechas de ingreso y de salida");
                //throw new Exception("Error con los las fechas ingresadas");
            }
            else
                txtDias.Text = dias.ToString();

        }
                

        private void btnGuardarPersona_Click(object sender, EventArgs e)  //botón para guardar un nuevo cliente
        {
            if (txtNombreTitular.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del titular");
                return;
            }
            if (txtNumID.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el número de identificación del titular");
                return;
            }

            if (comboBoxTipoPersona.SelectedIndex == 0) //1 = huesped
            {

                listClientes.Items.Add(new Huesped(txtNombreTitular.Text, long.Parse(txtNumID.Text)));
                Reservas.ListaPersona.Add(new Huesped(txtNombreTitular.Text, long.Parse(txtNumID.Text)));

            }
            else if (comboBoxTipoPersona.SelectedIndex ==1)  //2=> Cliente
            {
                
                listClientes.Items.Add(new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text)));
                Reservas.ListaPersona.Add(new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text)));

            }            
                                  
        }

        private void LlenarListaPersonas(List<Persona> lista)
        {
            foreach (Persona item in lista)
            {
                listClientes.Items.Add(item); //listbox
            }
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.personaTemp = (Persona)listClientes.SelectedItem;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close(); //Cierra esta ventana en especifico
        }

        private void txtNumReserva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CrearReserva_Load(object sender, EventArgs e)
        {

        }
        

        private void btnConfirmar_Click(object sender, EventArgs e) 
        {
            

            //la idea es recorrer la lista de las habitaciones ya existentes para ocupar 
            // una habitación (cambiar el estado) y crear la reserva de ese cliente con dicha habitación
            // esa habitación corresponde al tipo seleccionado. 

            Persona titular = null;
            if ( comboBoxTipoPersona.SelectedIndex == 0)
            {
                titular = new Huesped(txtNombreTitular.Text, long.Parse(txtNumID.Text));
            }

            if (comboBoxTipoPersona.SelectedIndex == 1)
            {
                titular = new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text));
            }

            if (comboBox1.Text == "Sencilla")
            {
                foreach (var item in Principal.infoHabitaciones) 
                {
                    if (Convert.ToString(item.TipoHab).Equals("Sencilla") && Convert.ToString(item.EstadoHab).Equals("Desocupada"))
                    {
                        
                        if (dias == 0 || titular == null)
                        {
                            MessageBox.Show("Debe calcular los días de la estadía o ingresar un titular para la reserva");
                        }
                        else
                        {
                            item.EstadoHab = Habitacion.estado.Reservada;
                            item.Titular = titular;
                            if (cBtipoCama.Text == "Sencilla")
                            {
                                switch (cBtipoCama.SelectedIndex)
                                {
                                    case 0:
                                        item.TipoDeCama = Habitacion.tipoCama.doble;
                                        break;
                                    case 1:
                                        item.TipoDeCama = Habitacion.tipoCama.sencilla;
                                        break;
                                    default:
                                        item.TipoDeCama = Habitacion.tipoCama.sencilla;
                                        break;
                                }
                            }
                            else if(cBtipoCama.Text == "Ejecutiva")
                            {
                                switch (cBtipoCama.SelectedIndex)
                                {
                                    case 0:
                                        item.TipoDeCama = Habitacion.tipoCama.queen;
                                        break;
                                    case 1:
                                        item.TipoDeCama = Habitacion.tipoCama.semidoble;
                                        break;
                                    default:
                                        item.TipoDeCama = Habitacion.tipoCama.sencilla;
                                        break;
                                }
                            }
                            else if(cBtipoCama.Text == "Suite")
                            {
                                switch (cBtipoCama.SelectedIndex)
                                {
                                    case 0:
                                        item.TipoDeCama = Habitacion.tipoCama.king;
                                        break;
                                    case 1:
                                        item.TipoDeCama = Habitacion.tipoCama.king;
                                        break;
                                    default:
                                        item.TipoDeCama = Habitacion.tipoCama.sencilla;
                                        break;
                                }
                            }
                            Reserva rsvaSencilla = new Reserva(titular, item); //item es la habitación
                            rsvaSencilla.Dias = int.Parse(txtDias.Text); //AQUI
                            MessageBox.Show($"La habitación de {titular.Nombre} fue reservada exitosamente, su habitación es: {rsvaSencilla.Habitacion.NumHabitacion}");
                            Reservas.ListaReservas.Add(rsvaSencilla);
                            txtNumReserva.Text = rsvaSencilla.NumReserva.ToString();
                        }

                        return; 
                    }
                    
                }

            }
            if (comboBox1.Text == "Suite")
            {
                foreach (var item in Principal.infoHabitaciones)
                {
                    if (Convert.ToString(item.TipoHab).Equals("Suite") && Convert.ToString(item.EstadoHab).Equals("Desocupada"))
                    {
                        if (dias == 0 || titular == null)
                        {
                            MessageBox.Show("Debe calcular los días de la estadía o ingresar un titular para la reserva");
                        }
                        else
                        {
                            item.EstadoHab = Habitacion.estado.Reservada;
                            item.Titular = titular;
                            Reserva rsvaSuite = new Reserva(titular, item); //item es la habitación
                            rsvaSuite.Dias = int.Parse(txtDias.Text);
                            MessageBox.Show($"La habitación de {titular.Nombre} fue reservada exitosamente, su habitación es: {rsvaSuite.Habitacion.NumHabitacion}");
                            Reservas.ListaReservas.Add(rsvaSuite);
                            txtNumReserva.Text = rsvaSuite.NumReserva.ToString();
                        }
                        
                        return; 
                    }
                    
                }

            }
            if (comboBox1.Text == "Ejecutiva")
            {
                foreach (var item in Principal.infoHabitaciones)
                {
                    if (Convert.ToString(item.TipoHab).Equals("Ejecutiva") && Convert.ToString(item.EstadoHab).Equals("Desocupada"))
                    {
                        if (dias == 0 || titular == null)
                        {
                            MessageBox.Show("Debe calcular los días de la estadía o ingresar un titular para la reserva");
                        }
                        else
                        {
                            item.EstadoHab = Habitacion.estado.Reservada;
                            item.Titular = titular;
                            Reserva rsvaEjecutiva = new Reserva(titular, item); //item es la habitación
                            rsvaEjecutiva.Dias = int.Parse(txtDias.Text);
                            MessageBox.Show($"La habitación de {titular.Nombre} fue reservada exitosamente, su habitación es: {rsvaEjecutiva.Habitacion.NumHabitacion}");
                            Reservas.ListaReservas.Add(rsvaEjecutiva);
                            txtNumReserva.Text = rsvaEjecutiva.NumReserva.ToString();
                        }
                            
                        return;
                    }
                   
                }
            }
            if (comboBox1.Text == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de habitación");
                return;
            }
           



            //Reservas.Show();

            txtNumID.Text = string.Empty;
            txtNombreTitular.Text = string.Empty;
            comboBoxTipoPersona.SelectedIndex = 0;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Sencilla")
            {
                cBtipoCama.Items.Clear();
                cBtipoCama.Enabled = true;
                cBtipoCama.Items.Add("Cama doble");
                cBtipoCama.Items.Add("Dos camas sencillas");              
            }
            if (comboBox1.Text == "Ejecutiva")
            {
                cBtipoCama.Items.Clear();
                cBtipoCama.Enabled = true;
                cBtipoCama.Items.Add("Cama queen");
                cBtipoCama.Items.Add("Dos camas semidobles");
            }
            if (comboBox1.Text == "Suite")
            {
                cBtipoCama.Items.Clear();
                cBtipoCama.Enabled = true;
                cBtipoCama.Items.Add("Cama king");
                cBtipoCama.Items.Add("Una cama queen y una semidoble");
            }

        }
    }
}
