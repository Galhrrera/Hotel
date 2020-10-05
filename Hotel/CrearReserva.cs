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
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCDalcularDias_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = dtpFechaIngreso.Value.Date;
            DateTime fechaSalida = dtpFechaSalida.Value.Date;
            //dptFechaInicio & dptFechaFinal son los nombres de los box en el formulario
            TimeSpan tSpan = fechaSalida - fechaEntrada;

            int dias = tSpan.Days;

            //deberiamos usar try catch?
            if (dias <= 0)
            {
                txtDias.Text = "Por favor revise las fechas de ingreso y de salida";
                throw new Exception("Error con los las fechas ingresadas");
            }             
            else
                txtDias.Text = dias.ToString() + "días";
        }
    }
}
