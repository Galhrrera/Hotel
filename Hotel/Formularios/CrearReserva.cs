using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel
{
    public partial class CrearReserva : Form
    {
        private List<Persona> listatemp = new List<Persona>();
        private List<reserva> listaReservasCR = new List<reserva>();
        private Persona personaTemp;
       
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

            int dias = tSpan.Days;


            if (dias <= 0 || dias == null)
            {
                MessageBox.Show("Por favor revise las fechas de ingreso y de salida");
                throw new Exception("Error con los las fechas ingresadas");
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

            Habitacion habreservada = new Habitacion();
            //Persona personatemp = new Persona(txtNombreTitular.Text, long.Parse(txtNumID.Text));
            //Persona personatemp = new Persona(listClientes.SelectedItem.)
            if(comboBox1.Text == "Sencilla")
            {
                habreservada = new Sencilla();
                
            }
            if (comboBox1.Text == "Suite")
            {
                habreservada = new Suite();
            }
            if (comboBox1.Text == "Ejecutiva")
            {
                habreservada = new Ejecutiva();
            }
            if(comboBox1.Text == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de habitación");
                return;
            }

            reserva reservaTemp = new reserva();

            reservaTemp.Habitacion = habreservada;
            reservaTemp.Persona = personaTemp;

            reservaTemp.Dias = int.Parse(txtDias.Text.ToString());

            listaReservasCR.Add(reservaTemp);

            

            Reservas frmReservas = new Reservas(listaReservasCR);
            frmReservas.Show();

            txtNumID.Text = string.Empty;
            txtNombreTitular.Text = string.Empty;
            comboBoxTipoPersona.SelectedIndex = 0;

            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
