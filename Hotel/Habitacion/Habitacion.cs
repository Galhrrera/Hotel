using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Hotel
{
    public abstract class Habitacion
    {
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        public enum estado { Desocupada, Ocupada };

        public enum tipoHabitacion { Sencilla, Ejecutiva, Suite };

        private int numHabitacion;
        private int piso;
        private Huesped huesped;
        private float precio;
        private float totalMinibar;
        private estado estadoHab;
        private tipoHabitacion tipoHab;
        private List<PctoMinibar> listaMinibar = new List<PctoMinibar>(); 

        public int NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public int Piso { get => piso; set => piso = value; }
        public Huesped Huesped { get => huesped; set => huesped = value; }
        public float Precio { get => precio; set => precio = value; }
        public float TotalMinibar { get => totalMinibar; set => totalMinibar = value; }
        public List<PctoMinibar> ListaMinibar { get => listaMinibar; set => listaMinibar = value; }
        public estado EstadoHab { get => estadoHab; set => estadoHab = value; }
        public tipoHabitacion TipoHab { get => tipoHab; set => tipoHab = value; }

        protected Habitacion() { }


        public abstract void ReabastecerMinibar();

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

    }
}
