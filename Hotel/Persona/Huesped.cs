using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Huesped : Persona
    {
        public Huesped(string nombre, long num_id) : base(nombre, num_id) 
        {
            this.TipoDePersona = TipoPersona.Huesped;
        }
    }
}
