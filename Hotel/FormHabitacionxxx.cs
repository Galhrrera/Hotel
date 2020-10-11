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
            if (HabitacionEspecifica.Huesped == null)
            {
                txtNombreHuesped.Text = "Pendiente";
            }
            else
                txtNombreHuesped.Text = HabitacionEspecifica.Huesped.Nombre.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHabitacionxxx_Load(object sender, EventArgs e)
        {

        }
    }
}
