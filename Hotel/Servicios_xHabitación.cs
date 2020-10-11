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
    public partial class Servicios_xHabitación : Form
    {
        public Servicios_xHabitación()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restaurante_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (restaurante_menu.CheckedItems.Count == 1)
            {
                if (restaurante_menu.Text.Equals("Desayuno"))
                {
                    //Cargárselo a la habitación
                }
                if(restaurante_menu.Text.Equals("Almuerzo"))
                {
                    //Cargárselo a la habitación
                }
                if (restaurante_menu.Text.Equals("Cena"))
                {
                    //Cargárselo a la habitación
                }
            }
            else
            {
                MessageBox.Show("Solo puede seleccionar un elemento, gracias");
                for (int ix = 0; ix < restaurante_menu.Items.Count; ++ix)
                    if (ix !=2 || ix != 3) restaurante_menu.SetItemChecked(ix, false);
            }

            
        }

        private void lista_restaurante_Click(object sender, EventArgs e)
        {

        }

        private void solicitar_servicio_Click(object sender, EventArgs e)
        {

        }

        private void subtotal_lavanderia_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regresar_habitacion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.T || e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;
                Button1Click(this, EventArgs.Empty);
            }
            */
        }
    }
}
