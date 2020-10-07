using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class ServicioPedido
    {
        private Servicio servicio;
        private DateTime hora;
        private int numElementos;
        public Servicio Servicio { get => servicio; set => servicio = value; }
        public DateTime Hora { get => hora;}
        public int NumElementos { get => numElementos; set => numElementos = value; }

        public ServicioPedido(Servicio servicio, DateTime hora, int numElementos)
        {
            this.servicio = servicio;
            this.hora = DateTime.Now;
            this.numElementos = numElementos;
        }

       
    }
}
