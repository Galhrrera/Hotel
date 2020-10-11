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
        public List<reserva> listaReservas = new List<reserva>();
        public List<HabitacionReservada> listaHabitacionesReservadas = new List<HabitacionReservada>();
      

        public Reservas(List<reserva> listares)
        {
            //Asociar los datos de la lista al data
            if (listares != null)
            {
                listaReservas = listares;
            }
            else
            {
                listaReservas = new List<reserva>();
            }
            InitializeComponent();

            LlenarListaReservas(listaReservas);
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
            dataGridViewReservas.DataSource = listaReservas; //Debe ser lista de objetos de clase reserva o de objetos de clase habitacion reservada?
        }

        private void LlenarListaReservas(List<reserva> lista)
        {
            dataGridViewReservas.DataSource = lista;
        }

        private void groupBoxReservaHeader_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se cambiará el estado de la habitaci´n y se procederá a guardar la factura en un archivo de texto");
        }

        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
