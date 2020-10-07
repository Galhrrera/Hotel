using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Producto
    {
        private string nombreProducto;
        private float precioProducto;
        private int cantidadProducto; //cantidad de inventario del hotel

        public Producto(string nombreProducto, float precioProducto)
        {
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }


    }
}
