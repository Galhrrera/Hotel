using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class HabitacionReservada
    {
        private Habitacion habReservada;
        private float totalXhabitacion;
        private static List<ServicioPedido> listaServicios = new List<ServicioPedido>(); 

        public HabitacionReservada(Habitacion habReservada)
        {
            this.habReservada = habReservada; 
        }

        public float TotalXhabitacion { get => totalXhabitacion; set => totalXhabitacion = value; }
        public List<ServicioPedido> ListaServicios { get => listaServicios; set => listaServicios = value; }
        public Habitacion HabReservada { get => habReservada; set => habReservada = value; }

        public static void PedirServicio(Servicio servicio, int cant)
        {
            listaServicios.Add(new ServicioPedido(servicio, cant));
        }
        public double CalcularTotalServicio(ServicioPedido servicioPdo)
        {
            try
            {
                double total = servicioPdo.Servicio.Precio * servicioPdo.NumElementos; 
                return total;
            }
            catch
            {
                throw new Exception();
            }
            
        }

    }
}
