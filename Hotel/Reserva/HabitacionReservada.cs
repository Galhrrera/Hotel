using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class HabitacionReservada
    {
        private Habitacion habReservada;
        private float totalXhabitacion;
        private List<ServicioPedido> listaServicios = new List<ServicioPedido>(); 

        public HabitacionReservada(Habitacion habReservada)
        {
            this.habReservada = habReservada;
            
        }

        public float TotalXhabitacion { get => totalXhabitacion; set => totalXhabitacion = value; }
        public List<ServicioPedido> ListaServicios { get => listaServicios; set => listaServicios = value; }
        public Habitacion HabReservada { get => habReservada; set => habReservada = value; }
        public static float CalcularPrecioServicio()
        {
            //Calcular el precio segun los servicios pedidos
            float precioservicio = 0;
            return precioservicio;
        }
        public float CalcularPrecioMinibar()
        {
            //Calcular el precio del minibar según los productos consumidos
            float preciominibar = 0;

            return preciominibar;
        }
    }
}
