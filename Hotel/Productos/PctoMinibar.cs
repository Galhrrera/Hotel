using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel___Proyecto_Final
{
    public class PctoMinibar
    {
        private byte CantidadInicial;
        private Producto producto;
        private byte CantidadFinal;

        public byte CantidadInicial1 { get => CantidadInicial; set => CantidadInicial = value; }
        public byte CantidadFinal1 { get => CantidadFinal; set => CantidadFinal = value; }
        internal Producto Producto { get => producto; set => producto = value; }
    }
}
