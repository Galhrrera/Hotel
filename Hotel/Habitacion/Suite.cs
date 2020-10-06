using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Suite : Habitacion
    {
        public Suite() 
        {
            Producto botellaVino = new Producto("Botella de vino", 50000, 1); 
            Producto botellaLicor = new Producto("Botella de licor", 25000, 4);
            Producto kitAseo = new Producto("Kit de aseo personal", 9000, 3);
            Producto gaseosa = new Producto("Gaseosa", 3000, 4);
            Producto bata = new Producto("Bata de baño", 70000, 2);
            ListaMinibar.Add(botellaVino);
            ListaMinibar.Add(botellaLicor);
            ListaMinibar.Add(kitAseo);
            ListaMinibar.Add(gaseosa);
            ListaMinibar.Add(bata);
        }

        public override void Consumir(List<Producto> ListaMinibar, int cantConsumir)
        {
            foreach (var item in ListaMinibar)
            {
                if (cantConsumir <= item.CantidadProducto)
                {
                    if (item.NombreProducto.Equals("Botella de licor"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + (item.PrecioProducto * cantConsumir);
                    }
                    if (item.NombreProducto.Equals("Botella de vino"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + (item.PrecioProducto * cantConsumir);
                    }
                    if (item.NombreProducto.Equals("Bata de baño"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + (item.PrecioProducto * cantConsumir);
                    }
                    if (item.NombreProducto.Equals("Gaseosa"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + (item.PrecioProducto * cantConsumir);
                    }
                    if (item.NombreProducto.Equals("Kit de aseo personal"))
                    {
                        item.CantidadProducto -= cantConsumir;
                        TotalMinibar = TotalMinibar + (item.PrecioProducto * cantConsumir);
                    }
                }

            }

        }

        public override void ReabastecerMinibar(List<Producto> ListaMinibar)
        {
            foreach (var item in ListaMinibar)
            {
                if (item.NombreProducto.Equals("Botella de licor"))
                {
                    item.CantidadProducto = 4;
                }
                if (item.NombreProducto.Equals("Botella de vino"))
                {
                    item.CantidadProducto = 1;
                }
                if (item.NombreProducto.Equals("kit de aseo personal"))
                {
                    item.CantidadProducto = 3;
                }
                if (item.NombreProducto.Equals("Gaseosa"))
                {
                    item.CantidadProducto = 4;
                }
                if (item.NombreProducto.Equals("Bata de baño"))
                {
                    item.CantidadProducto = 2;
                }
            }
        }
    }
}
