using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel
{
    class Check_Out : Facturacion
    {
        public static Check_Out CheckOut;

        public void GenerarFactura(Reserva rsv)
        {
            

            StreamWriter archivo = new StreamWriter("Factura.txt");

            double subtotal = 0, seguro = 0, totalNoches = 0, totalProductosXHab = 0, totalServiciosXhab = 0, IVA = 1.19, total = 0;

            seguro = 0.025 * rsv.Habitacion.Precio;

            totalNoches = rsv.Habitacion.Precio * (rsv.Dias-1);

            subtotal = seguro  +  totalNoches  +  totalProductosXHab  +  totalServiciosXhab;

            total = subtotal * IVA;

            archivo.WriteLine("A continuación se generará su factura para la habitación: {0}", rsv.Habitacion.NumHabitacion.ToString());  ;
            archivo.WriteLine("Total por noches en {0} es: ${1} ", (rsv.Dias - 1), totalNoches.ToString());
            archivo.WriteLine("El total de los productos consumidos es: ${0}", totalProductosXHab.ToString());
            archivo.WriteLine("El total de los servicios utilizados es: ${0}", totalServiciosXhab.ToString());
            archivo.WriteLine("El seguro es de: ${0}", seguro.ToString());
            archivo.WriteLine("El Subtotal es: ${0}", subtotal.ToString());
            archivo.WriteLine();
            archivo.WriteLine("EL TOTAL A PAGAR ES: ${0}", total.ToString());

            archivo.Close();
        }
        
    }
}
