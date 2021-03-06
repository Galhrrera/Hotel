﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.IO;

namespace Hotel
{
    public class Habitacion
    {
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        public enum estado { Desocupada, Ocupada, Reservada };

        public enum tipoHabitacion { Sencilla, Ejecutiva, Suite };

        private int numHabitacion;
        private int piso;
        private Persona titular;
        private float precio;
        private estado estadoHab;
        private tipoHabitacion tipoHab;
        private tipoCama tipoDeCama;
        private List<PctoMinibar> listaMinibar = new List<PctoMinibar>();
        private string path;
        //private static List<Producto> listaDeProductos = new List<Producto>();

        public int NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public int Piso { get => piso; set => piso = value; }
        public Persona Titular { get => titular; set => titular = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<PctoMinibar> ListaMinibar { get => listaMinibar; set => listaMinibar = value; }
        public estado EstadoHab { get => estadoHab; set => estadoHab = value; }
        public tipoHabitacion TipoHab { get => tipoHab; set => tipoHab = value; }
        public tipoCama TipoDeCama { get => tipoDeCama; set => tipoDeCama = value; }
        public string Path { get => path; set => path = value; }

        //public static List<Producto> ListaDeProductos { get => listaDeProductos; set => listaDeProductos = value; }

        public Habitacion() { }


        public virtual void ReabastecerMinibar()
        {
            try
            {
                int cantidad;

                string[] vectorTempProducto = new string[3];


                string[] linea = System.IO.File.ReadAllLines(path);



                for (int i = 0; i < linea.Length; i++)
                {
                    vectorTempProducto = linea[i].Split('#');

                    cantidad = int.Parse(vectorTempProducto[0]);
                    Producto productoTemp = new Producto(vectorTempProducto[1], Convert.ToDouble(vectorTempProducto[2]));
                    AdicionarPctoMinibar(productoTemp, cantidad);
                }

            }
            catch
            {
                throw new Exception();
            }
        }

        public virtual void Consumir(Producto pcto, int cantConsumir)
        {
            try
            {
                foreach (var item in ListaMinibar)
                {
                    if (item.Producto.NombreProducto == pcto.NombreProducto)
                    {
                        item.CantidadFinal = item.CantidadFinal - cantConsumir;
                    }
                }
            }
            catch
            {
                throw new Exception(); 
            }
           
        }

        public void AdicionarPctoMinibar(Producto producto, int cant)
        {
            try
            {
                listaMinibar.Add(new PctoMinibar(cant, producto));
            }
            catch
            {
                throw new Exception();
            }
            
        }
        

        public override string ToString()
        {
            string estadohabitación = null, tipohabitacionlst = null;
            if (estadoHab == Habitacion.estado.Desocupada)
                estadohabitación = "Desocupada";
            else if (estadoHab == Habitacion.estado.Ocupada)
                estadohabitación = "Ocupada     ";
            else if (estadoHab == Habitacion.estado.Reservada)
                estadohabitación = "Reservada   ";

            if (tipoHab == tipoHabitacion.Ejecutiva)
                tipohabitacionlst = "Ejecutiva";
            else if (tipoHab == tipoHabitacion.Sencilla)
                tipohabitacionlst = "Sencilla";
            else if (tipoHab == tipoHabitacion.Suite)
                tipohabitacionlst = "Suite";

            string texto;
            if (titular == null)
            {
                texto = "Número de habitación: " + numHabitacion + "     Estado: " + estadohabitación +
                "    Tipo de Habitación: " + tipohabitacionlst;
            }
            else
            {
                texto = "Número de habitación: " + numHabitacion + "     Estado: " + estadohabitación +
                "    Tipo de Habitación: " + tipohabitacionlst + " Titular: " + titular.Nombre;
            }
                

            return texto;
        }
    }
}
