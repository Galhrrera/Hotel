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
    public partial class FormHabitacionxxx : Form
    {
        private Habitacion HabitacionEspecifica;
        public static double subtotalMinibar = 0;

        public static double SubtotalMinibar { get => subtotalMinibar; set => subtotalMinibar = value; }

        public FormHabitacionxxx(Habitacion habSpec)
        {
            InitializeComponent();
            this.HabitacionEspecifica = habSpec;
            lblNumHabitacion.Text = HabitacionEspecifica.NumHabitacion.ToString();
            txtTipoHab.Text = HabitacionEspecifica.TipoHab.ToString();
            txtTipoCama.Text = HabitacionEspecifica.TipoDeCama.ToString();
            if (HabitacionEspecifica.Titular == null)
            {
                txtNombreHuesped.Text = "Ninguno";
            }
            else
                txtNombreHuesped.Text = HabitacionEspecifica.Titular.Nombre.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHabitacionxxx_Load(object sender, EventArgs e)
        {
                                                    
            listBoxPruductos.DataSource = HabitacionEspecifica.ListaMinibar;
            
        }

        

        private void btnServicios_Click(object sender, EventArgs e)
        {
            if(HabitacionEspecifica.EstadoHab == Habitacion.estado.Ocupada)
            {
                Servicios_xHabitación frmServicioXHabitacion = new Servicios_xHabitación();
                frmServicioXHabitacion.Show();
            }
            else
            {
                MessageBox.Show("No se pueden solicitar servicios debido a que la habitación está desocupada.");
                Close(); 
            }
            
        }

        private void listBoxPruductos_DoubleClick(object sender, EventArgs e)
        {
            int cont = 0; 

            foreach (var item in HabitacionEspecifica.ListaMinibar)
            {
                if(HabitacionEspecifica.EstadoHab == Habitacion.estado.Ocupada)
                {
                    if (listBoxPruductos.SelectedItem == item)
                    {
                        if(item.CantidadFinal > 0)
                        {
                            if (listBoxPruductos.SelectedItem == item)
                            {
                                item.CantidadFinal -= 1;
                                MessageBox.Show($"Consumiste: {item.Producto.NombreProducto}");

                                listBoxPruductos.DataSource = null;
                                listBoxPruductos.DataSource = HabitacionEspecifica.ListaMinibar;
                                subtotalMinibar += item.Producto.PrecioProducto * (item.CantidadInicial - item.CantidadFinal);
                                txtSubTotal.Text = "$ " + subtotalMinibar.ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay más productos");
                        }
                        
                    }
                }
                else if(cont == 0)
                {
                    cont++;
                    MessageBox.Show("No se pueden consumir productos porque la habitación está desocupada");
                    Close(); 
                }
                
            }

        }

        
    }
}
