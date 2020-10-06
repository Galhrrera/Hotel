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
        List<Persona> listatemp = new List<Persona>();

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

            //deberiamos usar try catch?
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

            if (comboBoxTipoPersona.SelectedIndex == 0) //1 = huesped & 2 = cliente
            {
                //Huesped H1 = new Huesped(txtNombreTitular.Text, long.Parse(txtNumID.Text));
                listClientes.Items.Add(new Huesped(txtNombreTitular.Text, long.Parse(txtNumID.Text)));
                //listatemp.Add(H1);
                
            }
            else if (comboBoxTipoPersona.SelectedIndex ==1)  //2=> Cliente
            {
                //Cliente C1 = new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text));
                listClientes.Items.Add(new Cliente(txtNombreTitular.Text, long.Parse(txtNumID.Text)));
                //listatemp.Add(C1);
                
            }    

            
            //Limpia los campos para poder reutilizarlos luego:
            txtNumID.Text = string.Empty;
            txtNombreTitular.Text = string.Empty;
            comboBoxTipoPersona.SelectedIndex = 0;
                                   
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

        
    }
}
