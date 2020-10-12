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
        public void GenerarFactura(Reserva rsv)
        {
            double subtotal = 0, seguro = 0, totalNoches = 0, totalProductosXHab = 0, totalServiciosXhab = 0, IVA = 0.19;

            seguro = 0.025 * rsv.Habitacion.Precio;

            totalNoches = rsv.Habitacion.Precio * rsv.Dias;

            subtotal = seguro
        }
        
    }
}
