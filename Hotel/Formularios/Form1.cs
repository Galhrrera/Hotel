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
        public static List<Habitacion> infoHabitaciones = new List<Habitacion>();
        public List<Habitacion> InfoHabitaciones { get => infoHabitaciones; set => infoHabitaciones = value; }

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
            Habitaciones habitaciones = new Habitaciones(InfoHabitaciones);
            habitaciones.Show();
        }

        public void Principal_Load(object sender, EventArgs e) //era private pero necesito que la clase CrearReserva.cs la acceda 
        {
            AccesoBD acceso = new AccesoBD(); 
            List<Habitacion> all_rooms = new List<Habitacion>();    
            InfoHabitaciones = acceso.GenerarHabitaciones();

        }

        private void lblNombreHotel_Click(object sender, EventArgs e)
        {

        }

        private void foto_hotel_Click(object sender, EventArgs e)
        {

        }

        public static void ValidarSoloLetras(KeyPressEventArgs V)
        {
            if (char.IsLetter(V.KeyChar))
                V.Handled = false;
            else if (char.IsSeparator(V.KeyChar))
                V.Handled = false;
            else if (char.IsControl(V.KeyChar))
                V.Handled = false;
            else
                V.Handled = true;
        }

        public static void ValidarSoloNumeros(KeyPressEventArgs V)
        {
            if (char.IsDigit(V.KeyChar))
                V.Handled = false;
            else if (char.IsSeparator(V.KeyChar))
                V.Handled = false;
            else if (char.IsControl(V.KeyChar))
                V.Handled = false;
            else
                V.Handled = true;
        }
    }
}
