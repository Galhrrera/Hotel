using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Producto
    {
        private string nombreProducto;
        private double precioProducto;        

        public Producto(string nombreProducto, double precioProducto)
        {
            this.nombreProducto = nombreProducto;
            this.precioProducto = precioProducto;
            
        }

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }        

        public override string ToString()
        {
            return nombreProducto + " $" + precioProducto;
        }

    }
}
