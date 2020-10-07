using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Sencilla : Habitacion
    {
        public Sencilla() { }

        public override void Consumir(Producto pcto, int cantConsumir) { }
        public override void ReabastecerMinibar() { }
    }
}
