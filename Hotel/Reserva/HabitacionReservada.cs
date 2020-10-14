using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class HabitacionReservada
    {
        private Habitacion habReservada;
        private static double totalXhabitacion = 0;
        private static List<ServicioPedido> listaServicios = new List<ServicioPedido>(); 

        public HabitacionReservada(Habitacion habReservada)
        {
            this.habReservada = habReservada; 
        }

        public double TotalXhabitacion { get => totalXhabitacion; set => totalXhabitacion = value; }
        public List<ServicioPedido> ListaServicios { get => listaServicios; set => listaServicios = value; }
        public Habitacion HabReservada { get => habReservada; set => habReservada = value; }

        public static ServicioPedido PedirServicio(Servicio servicio, int cant)
        {
            ServicioPedido nuevoServicio = new ServicioPedido(servicio, cant);
            listaServicios.Add(nuevoServicio);
            HabitacionReservada.CalcularTotalServicio(nuevoServicio);
            return nuevoServicio;
            
        }
        
        
        public static double CalcularTotalServicio(ServicioPedido servicioPdo)
        {
            try
            {
                                
                return servicioPdo.Servicio.Precio * servicioPdo.NumElementos;
            }
            catch
            {
                throw new Exception();
            }
            
        }

        public static void ObtenerTotalServicio(double subtotal)
        {
            totalXhabitacion = subtotal;
            
        }

    }
}
