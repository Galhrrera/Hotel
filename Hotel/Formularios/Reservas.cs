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
    public partial class Reservas : Form
    {
        public static List<Persona> ListaPersona = new List<Persona>();
        private static List<Reserva> listaReservas = new List<Reserva>();
        public List<HabitacionReservada> listaHabitacionesReservadas = new List<HabitacionReservada>();

        public static List<Reserva> ListaReservas { get => listaReservas; set => listaReservas = value; }

        public Reservas(List<Reserva> listares)
        {
            //Asociar los datos de la lista al data
            if (listares != null)
            {
                ListaReservas = listares;
            }
            else
            {
                ListaReservas = new List<Reserva>();
            }
            InitializeComponent();

            LlenarListaReservas(ListaReservas);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Parámetro de lista estática
            CrearReserva NuevaReserva = new CrearReserva(ListaPersona);
            NuevaReserva.Show();
            //NuevaReserva.ShowDialog();
            Close();

        }

        private void listReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            dataGridViewReservas.DataSource = ListaReservas; //Debe ser lista de objetos de clase reserva o de objetos de clase habitacion reservada?
        }

        private void LlenarListaReservas(List<Reserva> lista)
        {
            dataGridViewReservas.DataSource = lista;
        }

        private void groupBoxReservaHeader_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se cambiará el estado de la habitación y se procederá a guardar la factura en un archivo de texto");
        }

        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewReservas.DataSource = ListaReservas;
        }
    }
}
