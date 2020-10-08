using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Restaurante : Servicio
    {

        private List<Servicio> listaMenu;
        public List<Servicio> ListaMenu { get => listaMenu; set => listaMenu = value; }

        public Restaurante(bool room_service, float precio, string nombre) : base(room_service, precio, nombre)
        {
            Servicio desayuno = new Servicio(false, 15000, "Desayuno");
            Servicio almuerzo = new Servicio(false, 25000, "Almuerzo");
            Servicio cena = new Servicio(false, 20000, "Cena");
            ListaMenu.Add(desayuno);
            ListaMenu.Add(almuerzo);
            ListaMenu.Add(cena);
        }
        
    }
}
