using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Cliente : Persona
    {
        
        

        //el constructor de la clase es igual al del padre
        public Cliente(string nombre, long num_id) : base (nombre,num_id)
        {
            this.TipoDePersona = TipoPersona.Cliente;
            
        }
                
    }
}
