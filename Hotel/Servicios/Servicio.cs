using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Servicio
    {
        private bool room_service;
        private float precio;
        private string nombre;
        private float totalServicios;
        private ServicioPedido servicio; 

        public float Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float TotalServicios { get => totalServicios; set => totalServicios = value; }
        public bool Room_service { get => room_service; set => room_service = value; }

        public Servicio() { }
        public Servicio(float precio, string nombre)
        {
            this.precio = precio;
            this.nombre = nombre;
        }


        public virtual float CalcularSubtotal(List<Servicio> ListaMenu, int cant) { return 0; }

    }
}
