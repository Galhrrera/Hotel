using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Producto
    {
        private string nombreProducto;
        private double precioProducto;
        private int cantidadProducto; //cantidad de inventario del hotel

        public Producto(string nombreProducto, double precioProducto, int cant)
        {
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            this.cantidadProducto = cant;
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }


    }
}
