using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class AccesoBD
    {
        public void GenerarMinibarEjecutiva() //pendiente
        {
            try
            {

            }
            catch
            {
                throw new Exception(); 
            }
        }
        public List<Habitacion> GenerarHabitaciones()
        {
            try
            {
                List<Habitacion> infoHabitaciones = new List<Habitacion>();
                //For para crear habitaciones sencillas piso 2

                int numHabitacionPiso2 = 200;

                for (int i = 1; i <= 10; i++)
                {

                    Habitacion HabSencilla = new Sencilla();

                    HabSencilla.NumHabitacion = numHabitacionPiso2;

                    HabSencilla.Piso = 2;

                    HabSencilla.Precio = 200000;
                    HabSencilla.EstadoHab = Habitacion.estado.Desocupada;

                    numHabitacionPiso2++;

                    infoHabitaciones.Add(HabSencilla);

                }

                //For para crear habitaciones sencillas piso 3

                int numHabitacionPiso3 = 300;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion HabSencilla = new Sencilla();

                    HabSencilla.NumHabitacion = numHabitacionPiso3;

                    HabSencilla.Piso = 3;

                    HabSencilla.Precio = 200000;

                    HabSencilla.EstadoHab = Habitacion.estado.Desocupada;

                    numHabitacionPiso3++;

                    infoHabitaciones.Add(HabSencilla);

                }

                //For para crear habitaciones sencillas piso 4

                int numHabitacionPiso4 = 400;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion HabSencilla = new Sencilla();

                    HabSencilla.NumHabitacion = numHabitacionPiso4;

                    HabSencilla.Piso = 4;

                    HabSencilla.Precio = 200000;

                    HabSencilla.EstadoHab = Habitacion.estado.Desocupada;

                    numHabitacionPiso4++;

                    infoHabitaciones.Add(HabSencilla);

                }



                //For para crear habitaciones ejecutiva piso 5

                int numHabitacionPiso5 = 500;

                for (int i = 1; i <= 10; i++)

                {

                    Habitacion HabEjecutiva = new Ejecutiva();

                    HabEjecutiva.NumHabitacion = numHabitacionPiso5;

                    HabEjecutiva.Piso = 5;

                    HabEjecutiva.Precio = 350000;

                    HabEjecutiva.EstadoHab = Habitacion.estado.Desocupada;

                    numHabitacionPiso5++;

                    infoHabitaciones.Add(HabEjecutiva);

                }



                //For para crear habitaciones suite piso 6

                int numHabitacionPiso6 = 600;

                for (int i = 1; i <= 5; i++)

                {

                    Habitacion HabSuite = new Suite();

                    HabSuite.NumHabitacion = numHabitacionPiso6;

                    HabSuite.Piso = 6;

                    HabSuite.Precio = 500000;

                    HabSuite.EstadoHab = Habitacion.estado.Desocupada;

                    numHabitacionPiso6++;

                    infoHabitaciones.Add(HabSuite);

                }
                return infoHabitaciones;
            }
            catch
            {
                throw new Exception();
            }

        }
        
    }    
}
