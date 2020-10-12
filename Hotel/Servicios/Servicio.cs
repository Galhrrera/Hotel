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

        public Servicio(bool room_service, float precio, string nombre)
        {
            this.room_service = room_service;
            this.precio = precio;
            this.nombre = nombre;
        }

        public float Precio { get => precio; }
        public string Nombre { get => nombre; set => nombre = value; }
        public bool Room_service { get => room_service; set => room_service = value; }

    }
}
