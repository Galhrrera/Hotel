using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Suite : Habitacion
    {
        public Suite() 
        {
            ReabastecerMinibar(); 
        }

        public override void ReabastecerMinibar()
        {
            ListaMinibar = new List<PctoMinibar>();
            AdicionarPctoMinibar(new Producto("Botella de vino", 50000), 1);
            AdicionarPctoMinibar(new Producto("Botella de licor", 25000), 4);
            AdicionarPctoMinibar(new Producto("Kit de aseo personal", 9000), 3);
            AdicionarPctoMinibar(new Producto("Gaseosa", 3000), 4);
            AdicionarPctoMinibar(new Producto("Batas de baño", 70000), 2);
        }
    }
}
