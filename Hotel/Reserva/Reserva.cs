using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel
{
    public class Reserva
    {        
        private Persona persona;
        private int numReserva;        
        private int dias;
        private Habitacion habitacion;        
        private Random rnd = new Random(DateTime.Now.Millisecond);                                   //Generador de número de reserva
        private List<HabitacionReservada> listaHabitacionesRsv = new List<HabitacionReservada>();       //Se necesita la clase HabitacionReservada
                                                                                                     //Clase de asociación entre reserva y habitación
        
        public Persona Persona { get => persona; set => persona = value; }
        
        public List<HabitacionReservada> ListaHabitacionesRsv { get => listaHabitacionesRsv; set => listaHabitacionesRsv = value; }
        public int NumReserva { get => numReserva; set => numReserva = value; }
        public Habitacion Habitacion { get => habitacion; set => habitacion = value; }        
        public int Dias { get => dias; set => dias = value; }

        
        public Reserva(Persona persona, Habitacion habitacion) //para crear reserva se necesita una persona y una habitación 
        {
            this.persona = persona;
            this.habitacion = habitacion;

            NumReserva = rnd.Next(111111, 999999);
            listaHabitacionesRsv.Add(new HabitacionReservada(habitacion));
        }

        public void HacerCheckIn()
        {
            
            Habitacion.EstadoHab = Habitacion.estado.Ocupada;
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
