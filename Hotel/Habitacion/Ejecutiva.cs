using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Ejecutiva : Habitacion
    {
        //en el contructor se crea la lista con todos los elementos del minibar con sus respecivas
        //cantidades y precios. 
        public Ejecutiva()
        {
            ReabastecerMinibar();
        }

        public override void ReabastecerMinibar() 
        {
            ListaMinibar = new List<PctoMinibar>(); 

            AdicionarPctoMinibar(new Producto("Botella de licor", 25000), 4);
            AdicionarPctoMinibar(new Producto("Botella de Agua", 3500), 2);
            AdicionarPctoMinibar(new Producto("Kit de aseo personal", 9000), 1);
            AdicionarPctoMinibar(new Producto("Gaseosa", 3000), 2);
        }

    }
}
