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
        List<Persona> ListaPersona = new List<Persona>();
        List<reserva> listaReservas = new List<reserva>();
        
        public Reservas()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            CrearReserva NuevaReserva = new CrearReserva(ListaPersona);
            NuevaReserva.Show();
            //NuevaReserva.ShowDialog();

            
            
        }

        private void listReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
