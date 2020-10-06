using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Ejecutiva : Habitacion
    {
        public Ejecutiva()
        {
            Producto botellaLicor = new Producto("Botella de licor", 25000, 4);
            Producto botellaAgua = new Producto("Botella de Agua", 3500, 2);
            Producto kitAseo = new Producto("Kit de aseo personal", 9000, 1);
            Producto gaseosa = new Producto("Gaseosa", 3000, 2);
            //ListaMinibar.Add(botellaLicor);
            //ListaMinibar.Add(botellaAgua);
            //ListaMinibar.Add(kitAseo);
            //ListaMinibar.Add(gaseosa);
        }

        public override void Consumir(List<Producto> ListaMinibar, int cantConsumir)
        {
            foreach (var item in ListaMinibar)
            {
                if(cantConsumir <= item.CantidadProducto)
                {
                    if (item.NombreProducto.Equals("Botella de licor"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + item.PrecioProducto * cantConsumir; 
                    }
                    if (item.NombreProducto.Equals("Botella de Agua"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + item.PrecioProducto * cantConsumir;
                    }
                    if (item.NombreProducto.Equals("kit de aseo personal"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + item.PrecioProducto * cantConsumir;
                    }
                    if (item.NombreProducto.Equals("Gaseosa"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + item.PrecioProducto * cantConsumir;
                    }
                }
                
            }

        }

        public override void ReabastecerMinibar(List<Producto> ListaMinibar)
        {
            foreach (var item in ListaMinibar)
            {
                if(item.NombreProducto.Equals("Botella de licor"))
                {
                    item.CantidadProducto = 4;
                }
                if (item.NombreProducto.Equals("Botella de Agua"))
                {
                    item.CantidadProducto = 2;
                }
                if (item.NombreProducto.Equals("kit de aseo personal"))
                {
                    item.CantidadProducto = 1;
                }
                if (item.NombreProducto.Equals("Gaseosa"))
                {
                    item.CantidadProducto = 2;
                }
            }
        }
    }
}
