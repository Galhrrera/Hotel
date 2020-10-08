using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel
{
    public class reserva
    {        
        private Persona persona;
        private int numReserva;
        private Habitacion Habreservada;      
        private Random rnd = new Random(DateTime.Now.Millisecond); //Generador de número de reserva
        private List<HabitacionReservada> listaHabitaciones;       //Se necesita la clase HabitacionReservada
                                                                   //Clase de asociación entre reserva y habitación
        
        public Persona Persona { get => persona; }
        
        public List<HabitacionReservada> ListaHabitaciones { get => listaHabitaciones; }
        public int NumReserva { get => numReserva; set => numReserva = value; }
        public Habitacion Habreservada1 { get => Habreservada; set => Habreservada = value; }

        public reserva(Persona cliente)
        {
            persona = cliente;
            NumReserva = rnd.Next(111111, 999999);
        }
        public void HacerCheckIn()
        {
            this.NumReserva = rnd.Next(111111, 999999);
            //estado = Habitacion.estado.Ocupada;
        }

        public void HacerCheckOut()
        {
            string SalidaArchivo = "Factura.txt";                            //Ingresar la ruta en la que se debe crear el archivo.
            StreamWriter streamwriter = new StreamWriter(SalidaArchivo);
            //factura
            streamwriter.Close();
        }

        public void CalcularDias() //Este método fue implementado en el formulario de Crear Reserva
        {
            //this.fechaEntrada = dptFechaInicio.Value.Date;
            //this.fechaSalida = dptFechaFinal.Value.Date;
            //dptFechaInicio & dptFechaFinal son los nombres de los box en el formulario
            //tSpan = fechaSalida - fechaEntrada;

            //this.dias = tSpan.Days;
        }
    }
}
