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

        private void btnCheckIn_Click(object sender, EventArgs e)                           //CheckIN
        {
            foreach (var item in listaReservas)
            {
                if(dataGridViewReservas.CurrentRow.Cells[2].Value == item.Habitacion)
                {
                    item.Habitacion.EstadoHab = Habitacion.estado.Ocupada;
                    MessageBox.Show($"El estado de la habitación: {item.Habitacion.NumHabitacion.ToString()} ha sido actualizado a: OCUPADA.");
                }
            }
            
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
            foreach (var item in listaReservas)
            {
                if (dataGridViewReservas.CurrentRow.Cells[2].Value == item.Habitacion)
                {
                    if(item.Habitacion.EstadoHab == Habitacion.estado.Ocupada)
                    {
                        Check_Out check = new Check_Out();
                        check.GenerarFactura(item);
                        //Check_Out.CheckOut.GenerarFactura(item);
                        item.Habitacion.EstadoHab = Habitacion.estado.Desocupada;
                        MessageBox.Show($"El estado de la habitación: {item.Habitacion.NumHabitacion.ToString()} ha sido actualizado a: DESOCUPADA");
                    }
                    else
                    {
                        MessageBox.Show("La habitación no está ocupada");
                    }
                }
            }
        }

        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewReservas.DataSource = ListaReservas;
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
