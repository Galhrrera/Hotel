using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public interface Facturacion
    {
        public void GenerarFactura(Reserva reserva);

    }
}
