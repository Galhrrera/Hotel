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
            ReabastecerMinibar();         
        }

        public override void ReabastecerMinibar()
        {
            //Producto productoTemp = null;
            //string linea;

            int cantidad;            

            string[] vectorTempProducto = new string[3];
            

            string[] linea = System.IO.File.ReadAllLines("ProductosSuite.txt");

            

            for (int i = 0; i < linea.Length; i++)
            {
                vectorTempProducto = linea[i].Split('#');

                cantidad = int.Parse(vectorTempProducto[0]);
                Producto productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]));
                AdicionarPctoMinibar(productoTemp, cantidad);
            }
            

        }
        
    }
}
