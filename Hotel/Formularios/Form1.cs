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
        public List<Habitacion> infoHabitaciones = new List<Habitacion>(); // esto estaba en Principal_Load
        public AccesoBD acceso = new AccesoBD(); //esto estaba en Principal_Load
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
            Form reserva = new Reservas(null);
            reserva.Show();
        }

        public void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones(infoHabitaciones);
            habitaciones.Show();
        }

        public void Principal_Load(object sender, EventArgs e) //era private pero necesito que la clase CrearReserva.cs la acceda 
        {
            List<Habitacion> all_rooms = new List<Habitacion>();    
            infoHabitaciones = acceso.GenerarHabitaciones();
        }

        private void lblNombreHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
