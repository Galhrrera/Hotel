using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Persona 
    {
        //hola

        //atributos
        private string nombre; //es ingresado por el usuario
        private long num_id; //es ingresado por el usuario
        //propiedades
        protected string Nombre { get => nombre; set => nombre = value; }
        protected long Num_id { get => num_id; set => num_id = value; }

        //constructor - exige un nombre y un número de identificación para crear una persona
        public Persona(string nombre, long num_id)
        {
            Nombre = nombre;
            Num_id = num_id;
        }

        


    }
}
