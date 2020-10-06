using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Lavanderia : Servicio
    {
        private List<Servicio> listaServicios;
        public List<Servicio> ListaServicios { get => listaServicios; set => listaServicios = value; }
        public Lavanderia() 
        {
            Servicio lavarSacarRopa = new Servicio(500, "Lavar y secar ropa");
            Servicio plancharRopa = new Servicio(1000, "Planchar ropa");
            Servicio planchaVapor = new Servicio(2000, "Planchar ropa a vapor");
            ListaServicios.Add(lavarSacarRopa);
            ListaServicios.Add(plancharRopa);
            ListaServicios.Add(planchaVapor);
        }

        public override float CalcularSubtotal(List<Servicio> ListaServicio, int cant) 
        {
            foreach (var item in ListaServicios)
            {
                if(item.Nombre.Equals("Lavar y secar ropa"))
                {
                    TotalServicios = TotalServicios + cant * item.Precio;
                }
                if (item.Nombre.Equals("Planchar ropa"))
                {
                    TotalServicios = TotalServicios + cant * item.Precio;
                }
                if (item.Nombre.Equals("Planchar ropa a vapor"))
                {
                    TotalServicios = TotalServicios + cant * item.Precio;
                }
            }
            return TotalServicios; 
        }
    }
}
