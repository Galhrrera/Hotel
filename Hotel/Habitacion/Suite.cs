using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Hotel
{
    public class Suite : Habitacion
    {
        public Suite() 
        {
            this.TipoHab = tipoHabitacion.Suite;
            this.Path = "ProductosSuite.txt";
            ReabastecerMinibar();         
        }

        
        
    }
}
