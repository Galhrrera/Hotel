using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel
{
    public class Ejecutiva : Habitacion
    {
        //en el contructor se crea la lista con todos los elementos del minibar con sus respecivas
        //cantidades y precios. 
        public Ejecutiva()
        {
            this.TipoHab = tipoHabitacion.Ejecutiva;
            this.Path = "ProductosEjecutiva.txt";
            ReabastecerMinibar();
        }
        

    }
}
