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
        
        public Reservas()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form NuevaReserva = new CrearReserva(ListaPersona);
            NuevaReserva.Show();
        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
