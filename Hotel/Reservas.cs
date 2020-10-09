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
        List<reserva> listaReservas = new List<reserva>();
      

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



        }

        private void listReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            dataGridViewReservas.DataSource = listaReservas;
        }

        private void LlenarListaReservas(List<reserva> lista)
        {
            dataGridViewReservas.DataSource = lista;
        }

        private void groupBoxReservaHeader_Enter(object sender, EventArgs e)
        {

        }
    }
}
