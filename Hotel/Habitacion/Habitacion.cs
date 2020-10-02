using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel___Proyecto_Final
{
    public abstract class Habitacion
    {
        private byte numHabitacion;
        private byte piso;
        private Huesped huesped;
        private float precio;
        public enum tipoCama { doble, sencilla, queen, semidoble, king };
        private float totalMinibar;
        private List<PctoMinibar> listaMinibar;
        public enum estado { Desocupada, Ocupada };

        protected byte NumHabitacion { get => numHabitacion; }
        protected byte Piso { get => piso; }
        protected Huesped Huesped { get => huesped; }
        protected float Precio { get => precio; }
        protected float TotalMinibar { get => totalMinibar; }
        protected List<PctoMinibar> ListaMinibar { get => listaMinibar; }

        //¿CONSTRUCTOR?

        public static void ReabastecerMinibar()
        {
            //Añadir productos a la lista producto
        }

        public void Consumir(List<PctoMinibar> ListaMinibar)
        {
            //agregar el resultado a la lista
        }
    }
}
