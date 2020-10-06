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
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void btnRegresarHabitaciones_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHabitaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
