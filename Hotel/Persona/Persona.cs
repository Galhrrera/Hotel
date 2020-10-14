using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Persona 
    {
        public enum TipoPersona { Cliente, Huesped };
        //atributos
        private string nombre; //es ingresado por el usuario
        private long num_id; //es ingresado por el usuario
        private TipoPersona tipoDePersona;
        //propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public long Num_id { get => num_id; set => num_id = value; }
        public TipoPersona TipoDePersona { get => tipoDePersona; set => tipoDePersona = value; }

        //constructor - exige un nombre y un número de identificación para crear una persona
        

        public Persona(string nombre, long num_id)
        {
            Nombre = nombre;
            Num_id = num_id;
        }

        public override string ToString()
        {
            return ("Nombre: " + nombre + " -- ID: " + num_id);
        }

    }
}
