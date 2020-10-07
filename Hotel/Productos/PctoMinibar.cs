using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class PctoMinibar
    {
        private int cantidadInicial; 
        private Producto producto;
        private int cantidadFinal;

        public PctoMinibar(int cantidadInicial, Producto producto)
        {
            CantidadInicial = cantidadInicial;
            this.producto = producto;
            CantidadFinal = cantidadInicial; 
        }

        public int CantidadInicial { get => cantidadInicial; set => cantidadInicial = value; } 
        public Producto Producto { get => producto; set => producto = value; } //internal??
        public int CantidadFinal { get => cantidadFinal; set => cantidadFinal = value; }
    }
}
