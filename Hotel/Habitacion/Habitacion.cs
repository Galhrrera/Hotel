using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Hotel
{
    public class Habitacion
    {
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        public enum estado { Desocupada, Ocupada };

        private int numHabitacion;
        private int piso;
        private Huesped huesped;
        private float precio;
        private estado estadoHab;
        private List<PctoMinibar> listaMinibar = new List<PctoMinibar>(); 

        public int NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public int Piso { get => piso; set => piso = value; }
        public Huesped Huesped { get => huesped; set => huesped = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<PctoMinibar> ListaMinibar { get => listaMinibar; set => listaMinibar = value; }
        public estado EstadoHab { get => estadoHab; set => estadoHab = value; }

        public Habitacion() { }


        public virtual void ReabastecerMinibar() { }

        public virtual void Consumir(Producto pcto, int cantConsumir)
        {
            foreach (var item in ListaMinibar)
            {
                if (item.Producto.NombreProducto == pcto.NombreProducto)
                {
                    item.CantidadFinal = item.CantidadFinal - cantConsumir;
                }
            }
        }

        public void AdicionarPctoMinibar(Producto producto, int cant)
        {
            listaMinibar.Add(new PctoMinibar(cant, producto)); 
        }

        public double CalcularTotalMinibar(PctoMinibar productoMinibar)
        {
            double totalMB = (productoMinibar.CantidadInicial - productoMinibar.CantidadFinal) * productoMinibar.Producto.PrecioProducto;
            return totalMB; 
        }
    }
}
