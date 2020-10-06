using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class PctoMinibar
    {
        private byte CantidadInicial;
        private Producto producto;
        private byte CantidadFinal;

        public byte CantidadInicial1 { get => CantidadInicial; set => CantidadInicial = value; } //¿Por qué sale "1" al final del nombre de la propiedad? 
        public Producto Producto { get => producto; set => producto = value; } //internal??
        public byte CantidadFinal1 { get => CantidadFinal; set => CantidadFinal = value; }
    }
}
