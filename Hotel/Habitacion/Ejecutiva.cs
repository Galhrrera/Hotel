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
            ReabastecerMinibar();
        }
        public override void ReabastecerMinibar() 
        {
            int cantidad;

            string[] vectorTempProducto = new string[3];

            string[] linea = System.IO.File.ReadAllLines("ProductosEjecutiva.txt");

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
