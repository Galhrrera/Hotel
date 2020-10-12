using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Hotel
{
    public class Habitacion
    {
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        public enum estado { Desocupada, Ocupada, Reservada };

        public enum tipoHabitacion { Sencilla, Ejecutiva, Suite };

        private int numHabitacion;
        private int piso;
        private Huesped huesped;
        private float precio;
        private estado estadoHab;
        private tipoHabitacion tipoHab;
        private List<PctoMinibar> listaMinibar = new List<PctoMinibar>(); 

        public int NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public int Piso { get => piso; set => piso = value; }
        public Huesped Huesped { get => huesped; set => huesped = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<PctoMinibar> ListaMinibar { get => listaMinibar; set => listaMinibar = value; }
        public estado EstadoHab { get => estadoHab; set => estadoHab = value; }
        public tipoHabitacion TipoHab { get => tipoHab; set => tipoHab = value; }

        public Habitacion() { }


        public virtual void ReabastecerMinibar() { }

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

        public double CalcularTotalMinibar(PctoMinibar productoMinibar)
        {
            try
            {
                double totalMB = (productoMinibar.CantidadInicial - productoMinibar.CantidadFinal) * productoMinibar.Producto.PrecioProducto;
                return totalMB; 
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
            if (huesped == null)
            {
                texto = "Número de habitación: " + numHabitacion + "     Estado: " + estadohabitación +
                "    Tipo de Habitación: " + tipohabitacionlst;
            }
            else
            {
                texto = "Número de habitación: " + numHabitacion + "     Estado: " + estadohabitación +
                "    Tipo de Habitación: " + tipohabitacionlst + " Titular: " + huesped.Nombre;
            }
                

            return texto;
        }
    }
}
