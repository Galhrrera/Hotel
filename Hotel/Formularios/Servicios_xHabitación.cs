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
        List<Servicio> listaServicios = new List<Servicio>();
        private double totalServicioXHab = 0;

        public double TotalServicioXHab { get => totalServicioXHab; set => totalServicioXHab = value; }

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
            
            bool RS = false;
            if (restaurante_menu.Text.Equals("Desayuno"))
            {
                if (cBroomService.Text == "Sí")
                {
                    RS = true;
                }
                else
                {
                    RS = false;
                }
                Servicio pdDesayuno = new Servicio(RS, 15000, "Desayuno");                

                if(txtCantPlatos.Text != string.Empty)
                {
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdDesayuno, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
                else
                {
                    MessageBox.Show("Se agregará un plato por defecto");
                    txtCantPlatos.Text = "1";
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdDesayuno, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
                
            }
            if (restaurante_menu.Text.Equals("Almuerzo"))
            {
                if (cBroomService.Text == "Sí")
                {
                    RS = true;
                }
                else
                {
                    RS = false;
                }
                Servicio pdAlmuerzo = new Servicio(RS, 25000, "Restaurante - Almuerzo");


                if (txtCantPlatos.Text != string.Empty)
                {
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdAlmuerzo, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
                else
                {
                    MessageBox.Show("Se agregará un plato por defecto");
                    txtCantPlatos.Text = "1";
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdAlmuerzo, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
            }
            if (restaurante_menu.Text.Equals("Cena"))
            {
                if (cBroomService.Text == "Sí")
                {
                    RS = true;
                }
                else
                {
                    RS = false;
                }
                Servicio pdCena = new Servicio(RS, 20000, "Restaurante - Cena");


                if (txtCantPlatos.Text != string.Empty)
                {
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdCena, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
                else
                {
                    MessageBox.Show("Se agregará un plato por defecto");
                    txtCantPlatos.Text = "1";
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdCena, int.Parse(txtCantPlatos.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
            }
            if (servicio_lavandería.Text.Equals("Lavar"))
            {
                Servicio pdLavandería = new Servicio(false, 12000, "Lavandería");
                
                if(txtCantPrendas.Text != string.Empty)
                {
                    totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdLavandería, int.Parse(txtCantPrendas.Text)));
                    Check_Out.ObtenerTotalServicio(totalServicioXHab);
                    MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad de prendas");
                }
                
            }
            if (servicio_lavandería.Text.Equals("Planchar"))
            {
                if (cBtipoPlancha.Text == "Normal")
                {
                    Servicio pdNormal = new Servicio(false, 9000, "Plancha normal");
                    
                    if(txtCantPrendas.Text != string.Empty)
                    {
                        totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdNormal, int.Parse(txtCantPrendas.Text)));
                        Check_Out.ObtenerTotalServicio(totalServicioXHab);
                        MessageBox.Show($"Se recargarán: ${totalServicioXHab.ToString()} a la cuenta");
                        MessageBox.Show("Se enviaron a planchar normal exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una cantidad de prendas");
                    }
                    
                }
                if (cBtipoPlancha.Text == "A vapor")
                {
                    Servicio pdVapor = new Servicio(false, 6000, "Plancha a vapor");
                    
                    if(txtCantPrendas.Text != string.Empty)
                    {
                        totalServicioXHab += HabitacionReservada.CalcularTotalServicio(HabitacionReservada.PedirServicio(pdVapor, int.Parse(txtCantPrendas.Text)));
                        Check_Out.ObtenerTotalServicio(totalServicioXHab);
                        MessageBox.Show(totalServicioXHab.ToString());
                        MessageBox.Show("Se enviaron a planchar a vapor exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una cantidad de prendas");
                    }
                    
                }

            }
           
        }


        private void subtotal_lavanderia_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicio_lavandería.Text.Equals("Planchar"))
            {
                cBtipoPlancha.Enabled = true;
            }
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

        private void Servicios_xHabitación_Load(object sender, EventArgs e)
        {

        }

        private void cBroomService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBroomService.SelectedItem.ToString().Equals("Sí"))
            {
                TotalServicioXHab += 5000; 
            }
        }
    }
}
