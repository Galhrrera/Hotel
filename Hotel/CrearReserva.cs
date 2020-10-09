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
        private List<reserva> listaReservas = new List<reserva>();
       
        public CrearReserva(List<Persona> lista)
        {
            InitializeComponent();

            if (lista != null)
                listatemp = lista;
            else
                listatemp = new List<Persona>();

            LlenarListaPersonas(lista);
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCDalcularDias_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = dtpFechaIngreso.Value.Date;
            DateTime fechaSalida = dtpFechaSalida.Value.Date;
            //dtpFechaEntrada & dtpFechaSalida son los nombres de los box en el formulario
            TimeSpan tSpan = fechaSalida - fechaEntrada;

            int dias = tSpan.Days;

            
            if (dias <= 0)
            {
                txtDias.Text = "Por favor revise las fechas de ingreso y de salida";
                throw new Exception("Error con los las fechas ingresadas");
            }             
            else
                txtDias.Text = dias.ToString() + " días";
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
                
            }
            else if (comboBoxTipoPersona.SelectedIndex ==1)  //2=> Cliente
            {
                
                listClientes.Items.Add(new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text)));
                
                
            }


            //Limpia los campos para poder reutilizarlos luego:

            //txtNumID.Text = string.Empty;
            //txtNombreTitular.Text = string.Empty;
            //comboBoxTipoPersona.SelectedIndex = 0;
                                  
        }

        private void LlenarListaPersonas(List<Persona> lista)
        {
            foreach (var item in lista)
            {
                listClientes.Items.Add(item);
            }
        }

        private void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            
            
            Persona personatemp = new Persona(txtNombreTitular.Text, long.Parse(txtNumID.Text));
            if(comboBox1.Text == "Sencilla")
            {; 
                reserva nuevareserva = new reserva(personatemp, new Sencilla());
                listaReservas.Add(nuevareserva);
            }
            if (comboBox1.Text == "Suite")
            {
                reserva nuevareserva = new reserva(personatemp, new Suite());
                listaReservas.Add(nuevareserva);
            }
            if (comboBox1.Text == "Ejecutiva")
            {
                reserva nuevareserva = new reserva(personatemp, new Ejecutiva());
                listaReservas.Add(nuevareserva);
            }
            if(comboBox1.Text == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de habitación");
                return;
            }




            //Reservas frmreservas = new Reservas(listaReservas);
            //frmreservas.ShowDialog();

            txtNumID.Text = string.Empty;
            txtNombreTitular.Text = string.Empty;
            comboBoxTipoPersona.SelectedIndex = 0;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
