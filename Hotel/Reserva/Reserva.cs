using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel___Proyecto_Final
{
    public class reserva
    {
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private Persona persona;
        private int numReserva;
        private int dias;                                          //num de dias reservados
        private TimeSpan tSpan;                                    //Estructura con la que se calcularan los días restando las fechas
        private Habitacion.estado estado;        
        private Random rnd = new Random(DateTime.Now.Millisecond); //Generador de número de reserva
        private List<HabitacionReservada> listaHabitaciones;       //Se necesita la clase HabitacionReservada
                                                                   //Clase de asociación entre reserva y habitación

        public DateTime FechaEntrada { get => fechaEntrada; }
        public DateTime FechaSalida { get => fechaSalida; }
        public Persona Persona { get => persona; }
        public int NumReserva { get => NumReserva; }
        public List<HabitacionReservada> ListaHabitaciones { get => listaHabitaciones; }

        public void HacerCheckIn()
        {
            this.numReserva = rnd.Next(111111, 999999);
            estado = Habitacion.estado.Ocupada;
        }

        public void HacerCheckOut()
        {
            string SalidaArchivo = "";                            //Ingresar la ruta en la que se debe crear el archivo.
            StreamWriter streamwriter = new StreamWriter(SalidaArchivo);
            //factura
            streamwriter.Close();
        }

        public void CalcularDias()
        {
            //this.fechaEntrada = dptFechaInicio.Value.Date;
            //this.fechaSalida = dptFechaFinal.Value.Date;
            //dptFechaInicio & dptFechaFinal son los nombres de los box en el formulario
            tSpan = fechaSalida - fechaEntrada;

            this.dias = tSpan.Days;
        }
    }
}
