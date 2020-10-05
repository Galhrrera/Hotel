using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel___Proyecto_Final
{
    public class Restaurante : Servicio
    {
        private bool room_service;
        private List<Servicio> listaMenu;

        public bool Room_service { get => room_service; set => room_service = value; }
        public List<Servicio> ListaMenu { get => listaMenu; set => listaMenu = value; }

        public Restaurante() 
        {
            Servicio desayuno = new Servicio(15000, "Desayuno");
            Servicio almuerzo = new Servicio(25000, "Almuerzo");
            Servicio cena = new Servicio(20000, "Cena");
            ListaMenu.Add(desayuno);
            ListaMenu.Add(almuerzo);
            ListaMenu.Add(cena);
        }
        public override float CalcularSubtotal(List<Servicio> ListaMenu, int cant)
        {
            foreach (var item in ListaMenu)
            {
                if(item.Nombre.Equals("Desayuno"))
                {
                    TotalServicios = TotalServicios + (item.Precio * cant);
                }
                if (item.Nombre.Equals("Almuerzo"))
                {
                    TotalServicios = TotalServicios + (item.Precio * cant);
                }
                if (item.Nombre.Equals("Cena"))
                {
                    TotalServicios = TotalServicios + (item.Precio * cant);
                }
            }
            return TotalServicios;
        }
    }
}
