using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class HabitacionReservada
    {
        private Habitacion habReservada;
        private double totalXhabitacion = 0;
        private static List<ServicioPedido> listaServicios = new List<ServicioPedido>(); 

        public HabitacionReservada(Habitacion habReservada)
        {
            this.habReservada = habReservada; 
        }

        public double TotalXhabitacion { get => totalXhabitacion; set => totalXhabitacion = value; }
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
                TotalXhabitacion += servicioPdo.Servicio.Precio * servicioPdo.NumElementos; 
                return TotalXhabitacion;
            }
            catch
            {
                throw new Exception();
            }
            
        }

    }
}
