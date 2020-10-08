using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Lavanderia : Servicio
    {
        private List<Servicio> listaServicios;
        public List<Servicio> ListaServicios { get => listaServicios; set => listaServicios = value; }
        public Lavanderia(bool room_service, float precio, string nombre) : base(room_service, precio, nombre)
        {
            Servicio lavarSacarRopa = new Servicio(false, 500, "Lavar y secar ropa");
            Servicio plancharRopa = new Servicio(false, 1000, "Planchar ropa");
            Servicio planchaVapor = new Servicio(false, 2000, "Planchar ropa a vapor");
            ListaServicios.Add(lavarSacarRopa);
            ListaServicios.Add(plancharRopa);
            ListaServicios.Add(planchaVapor);
        }

        
    }
}
