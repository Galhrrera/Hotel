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
    public partial class Principal : Form
    {
        private List<Habitacion> infoHabitaciones = new List<Habitacion>();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Form reserva = new Reservas();
            reserva.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones(infoHabitaciones);
            habitaciones.Show();


        }

        private void Principal_Load(object sender, EventArgs e)
        {
            AccesoBD acceso = new AccesoBD();
            infoHabitaciones = acceso.GenerarHabitaciones();
        }
    }
}
