using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public abstract class Habitacion
    {
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        public enum estado { Desocupada, Ocupada };

        private int numHabitacion;
        private byte piso;
        private Huesped huesped;
        private float precio;
        private float totalMinibar;
        private estado estadoHab;
        private List<Producto> listaMinibar;

        public int NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public byte Piso { get => piso; set => piso = value; }
        public Huesped Huesped { get => huesped; set => huesped = value; }
        public float Precio { get => precio; set => precio = value; }
        public float TotalMinibar { get => totalMinibar; set => totalMinibar = value; }
        public List<Producto> ListaMinibar { get => listaMinibar; set => listaMinibar = value; }
        public estado EstadoHab { get => estadoHab; set => estadoHab = value; }

        protected Habitacion() { }


        public abstract void ReabastecerMinibar(List<Producto> ListaMinibar);

        public abstract void Consumir(List<Producto> ListaMinibar, int cantConsumir);

    }
}
