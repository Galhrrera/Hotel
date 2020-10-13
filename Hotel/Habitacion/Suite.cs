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
            /*try
            {
                ListaMinibar = new List<PctoMinibar>();

                AdicionarPctoMinibar(new Producto("Botella de vino", 50000), 1);
                AdicionarPctoMinibar(new Producto("Botella de licor", 25000), 4);
                AdicionarPctoMinibar(new Producto("Kit de aseo personal", 9000), 3);
                AdicionarPctoMinibar(new Producto("Gaseosa", 3000), 4);
                AdicionarPctoMinibar(new Producto("Batas de baño", 70000), 2);
            }
            catch
            {
                throw new Exception();
            }*/
           
        }

        public static void LeerProductos()
        {
            Producto productoTemp = null;
            string linea;
            
            int cantidad;
            //PctoMinibar productoMiniBarTemp = null;

            string[] vectorTempProducto;

            StreamReader SR = new StreamReader("ProductosSuite.txt");

            linea = SR.ReadLine();

            while(linea != null)
            {
                vectorTempProducto = linea.Split('#');
                cantidad = int.Parse(vectorTempProducto[0]);
                productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]), cantidad);
                ListaDeProductos.Add(productoTemp);
                //productoMiniBarTemp = new PctoMinibar(cantidad, productoTemp);
                //ListaMinibar.Add(productoMiniBarTemp);
            }

            SR.Close();
        }
    }
}
