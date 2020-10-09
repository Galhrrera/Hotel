using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Lavanderia : Servicio
    {
        private List<Servicio> listaLavanderia;
        public List<Servicio> ListaLavanderia { get => listaLavanderia; set => listaLavanderia = value; }
        public Lavanderia(bool room_service, float precio, string nombre) : base(room_service, precio, nombre)
        {
            try
            {
                Servicio lavarSacarRopa = new Servicio(false, 500, "Lavar y secar ropa");
                Servicio plancharRopa = new Servicio(false, 1000, "Planchar ropa");
                Servicio planchaVapor = new Servicio(false, 2000, "Planchar ropa a vapor");
                listaLavanderia.Add(lavarSacarRopa);
                listaLavanderia.Add(plancharRopa);
                listaLavanderia.Add(planchaVapor);
            }
            catch
            {
                throw new Exception();
            }
            
        }

        
    }
}
