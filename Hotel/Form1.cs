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
    public partial class Principal : Form
    {
        private List<Habitacion> infoHabitaciones = new List<Habitacion>();

        public Principal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Form reserva = new Reservas();
            reserva.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            habitaciones.Show();

            //For para crear habitaciones sencillas piso 2

            int numHabitacionPiso2 = 200;

            int control = 0;

            do
            {
                for (int i = 1; i <= 10; i++)

                {

                    Habitacion Sencilla = new Sencilla();

                    Sencilla.NumHabitacion = numHabitacionPiso2;

                    Sencilla.Piso = 2;

                    Sencilla.Precio = 200000;


                    //Sencilla.estado.Desocupada;

                    numHabitacionPiso2++;

                    infoHabitaciones.Add(Sencilla);

                }

                //For para crear habitaciones sencillas piso 3

                int numHabitacionPiso3 = 300;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion Sencilla = new Sencilla();

                    Sencilla.NumHabitacion = numHabitacionPiso3;

                    Sencilla.Piso = 2;

                    Sencilla.Precio = 200000;

                    //Sencilla.estado.Desocupada;

                    numHabitacionPiso3++;

                    infoHabitaciones.Add(Sencilla);

                }

                //For para crear habitaciones sencillas piso 4

                int numHabitacionPiso4 = 400;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion Sencilla = new Sencilla();

                    Sencilla.NumHabitacion = numHabitacionPiso4;

                    Sencilla.Piso = 4;

                    Sencilla.Precio = 200000;

                    //Sencilla.estado.Desocupada;

                    numHabitacionPiso4++;

                    infoHabitaciones.Add(Sencilla);

                }



                //For para crear habitaciones ejecutiva piso 5

                int numHabitacionPiso5 = 500;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion Ejecutiva = new Ejecutiva();

                    Ejecutiva.NumHabitacion = numHabitacionPiso5;

                    Ejecutiva.Piso = 5;

                    Ejecutiva.Precio = 350000;

                    //Ejecutiva.estado.Desocupada;

                    numHabitacionPiso5++;

                    infoHabitaciones.Add(Ejecutiva);

                }



                //For para crear habitaciones suite piso 6

                int numHabitacionPiso6 = 600;

                for (int i = 1; i <= 5; i++)

                {

                    Habitacion Suite = new Suite();

                    Suite.NumHabitacion = numHabitacionPiso6;

                    Suite.Piso = 6;

                    Suite.Precio = 500000;

                    //Suite.estado.Desocupada;

                    numHabitacionPiso6++;

                    infoHabitaciones.Add(Suite);

                }
                control++;

            } while (control < 1);

            
        }
    }
}
