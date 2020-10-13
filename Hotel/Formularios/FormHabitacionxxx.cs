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
    public partial class FormHabitacionxxx : Form
    {
        private Habitacion HabitacionEspecifica;
        public FormHabitacionxxx(Habitacion habSpec)
        {
            InitializeComponent();
            this.HabitacionEspecifica = habSpec;
            lblNumHabitacion.Text = HabitacionEspecifica.NumHabitacion.ToString();
            txtTipoHab.Text = HabitacionEspecifica.TipoHab.ToString();
            txtTipoCama.Text = HabitacionEspecifica.TipoDeCama.ToString();
            if (HabitacionEspecifica.Titular == null)
            {
                txtNombreHuesped.Text = "Ninguno";
            }
            else
                txtNombreHuesped.Text = HabitacionEspecifica.Titular.Nombre.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHabitacionxxx_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreHuesped_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios_xHabitación frmServicioXHabitacion = new Servicios_xHabitación();
            frmServicioXHabitacion.Show();
        }
    }
}
