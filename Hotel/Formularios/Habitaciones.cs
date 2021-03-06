﻿using System;
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
        private List<Habitacion> ListaHabitaciones = null;
        public Habitaciones(List<Habitacion> habitaciones)
        {
            //Asociar los datos de la lista al data
            if(habitaciones != null)
            {
                ListaHabitaciones = habitaciones;
            }
            else
            {
                ListaHabitaciones = new List<Habitacion>();
            }
            InitializeComponent();
            
        }

        private void btnRegresarHabitaciones_Click(object sender, EventArgs e)
        {
            Close();
        }
 
        private void Habitaciones_Load(object sender, EventArgs e)
        {
            listHabitacionesHotel.DataSource = ListaHabitaciones;
        }
                

        private void listHabitacionesHotel_DoubleClick(object sender, EventArgs e)
        {
            foreach (var item in ListaHabitaciones)
            {
                
                if (listHabitacionesHotel.SelectedItem == item)
                {
                    FormHabitacionxxx frmHabSpec = new FormHabitacionxxx(item);                   
                    frmHabSpec.Show();
                    break;
                }
            }
        }

        private void listHabitacionesHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
