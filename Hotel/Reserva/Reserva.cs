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
        public List<HabitacionReservada> listaHabitacionesRsv = new List<HabitacionReservada>();       //Se necesita la clase HabitacionReservada
                                                                                                     //Clase de asociación entre reserva y habitación
        
        public Persona Persona { get => persona; set => persona = value; }
        
        
        public int NumReserva { get => numReserva; set => numReserva = value; }
        public Habitacion Habitacion { get => habitacion; set => habitacion = value; }        
        public int Dias { get => dias; set => dias = value; }
        public List<HabitacionReservada> ListaHabitacionesRsv { get => listaHabitacionesRsv; set => listaHabitacionesRsv = value; }

        public Reserva(Persona persona, Habitacion habitacion) //para crear reserva se necesita una persona y una habitación 
        {
            this.persona = persona;
            this.habitacion = habitacion;

            NumReserva = rnd.Next(111111, 999999);
            this.listaHabitacionesRsv.Add(new HabitacionReservada(habitacion));
        }

        public void HacerCheckIn()
        {          
            Habitacion.EstadoHab = Habitacion.estado.Ocupada;
        }

    }
}
