﻿using System;
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

            //Producto productoTemp = null;
            //string linea;

            int cantidad;
            //PctoMinibar productoMiniBarTemp = null;

            string[] vectorTempProducto = new string[3];

            //StreamReader SR = new StreamReader("ProductosEjecutiva.txt");

            string[] linea = System.IO.File.ReadAllLines("ProductosEjecutiva.txt");

            for (int i = 0; i < linea.Length; i++)
            {
                vectorTempProducto = linea[i].Split('#');

                cantidad = int.Parse(vectorTempProducto[0]);
                Producto productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]));
                AdicionarPctoMinibar(productoTemp, cantidad);
            }
            //SR.Close();

            /*try
            {
                

                

                while (linea != null)
                {
                    //vectorTempProducto = linea.Split('#');
                    cantidad = int.Parse(vectorTempProducto[0]);
                    Producto productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]));
                    
                    //productoMiniBarTemp = new PctoMinibar(cantidad, productoTemp);
                    //ListaMinibar.Add(productoMiniBarTemp);
                    AdicionarPctoMinibar(productoTemp, cantidad);
                }

                SR.Close();
            }
            catch
            {
                throw new Exception();
            }*/
            
        }

        /*public static void LeerProductos()
        {
            Producto productoTemp = null;
            string linea;

            int cantidad;
            PctoMinibar productoMiniBarTemp = null;

            string[] vectorTempProducto;

            StreamReader SR = new StreamReader("ProductosEjecutiva.txt");

            linea = SR.ReadLine();

            while (linea != null)
            {
                vectorTempProducto = linea.Split('#');
                cantidad = int.Parse(vectorTempProducto[0]);
                productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]));
                ListaDeProductos.Add(productoTemp);
                productoMiniBarTemp = new PctoMinibar(cantidad, productoTemp);
                //ListaMinibar.Add(productoMiniBarTemp);
            }

            SR.Close();
        }*/

    }
}
