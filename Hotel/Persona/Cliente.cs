using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel___Proyecto_Final
{
    public class Cliente : Persona
    {
        private int codigo_especial; //será generado por el programa (random)
        private Random rnd = new Random();
        public int Codigo_especial { get => codigo_especial; }

        //el constructor de la clase es igual al del padre
        public Cliente(string nombre, long num_id) : base (nombre,num_id)
        {
            codigo_especial = rnd.Next(0, 999999999); ;
        }
        
        public void CalcularDescuentoSemanal()
        {
            //al final... al pagar todo en el checkout, se le hace un descuento. 
        }
    }
}
