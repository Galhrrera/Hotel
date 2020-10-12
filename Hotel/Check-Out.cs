﻿using System;
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
        private double subtotal = 0;
        private double seguro = 0;
        private double totalNoches = 0;
        private double totalProductosXHab = 0;
        private double totalServiciosXHab = 0;
        private double IVA = 1.19;
        private double total = 0;
        private double DescuentoCliente = 0.1;

        public double Subtotal { get => subtotal; }
        public double Seguro { get => seguro; }
        public double TotalNoches { get => totalNoches; }
        public double TotalProductosXHab { get => totalProductosXHab; }
        public double TotalServiciosXHab { get => totalServiciosXHab; }
        public double IVA1 { get => IVA; }
        public double Total { get => total; }
        public double DescuentoCliente1 { get => DescuentoCliente; }

        public static Check_Out GetCheck_Out()
        {
            if (CheckOut is null)
                CheckOut = new Check_Out();

            return CheckOut;
        }
        public void GenerarFactura(Reserva rsv)
        {
            if(rsv.Persona.TipoDePersona == Persona.TipoPersona.Cliente)
            {
                StreamWriter archivo = new StreamWriter("Factura.txt");
                

                seguro = 0.025 * rsv.Habitacion.Precio;

                totalNoches = rsv.Habitacion.Precio * (rsv.Dias - 1);

                subtotal = seguro + totalNoches + totalProductosXHab + totalServiciosXHab;

                total = subtotal * IVA;
                total -= total * DescuentoCliente;

                archivo.WriteLine("A continuación se generará su factura para la habitación: {0}", rsv.Habitacion.NumHabitacion.ToString()); ;
                archivo.WriteLine("Total por noches en {0} es: ${1} ", (rsv.Dias - 1), totalNoches.ToString());
                archivo.WriteLine("El total de los productos consumidos es: ${0}", totalProductosXHab.ToString());
                archivo.WriteLine("El total de los servicios utilizados es: ${0}", totalServiciosXHab.ToString());
                archivo.WriteLine("El seguro es de: ${0}", seguro.ToString());
                archivo.WriteLine("El Subtotal es: ${0}", subtotal.ToString());                
                archivo.WriteLine();
                archivo.WriteLine("Al tratarse de un Cliente del hotel, se le realizará un descuneto del 10% sobre su valor total");
                archivo.WriteLine("EL TOTAL A PAGAR ES: ${0}", total.ToString());

                archivo.Close();
            }

            if (rsv.Persona.TipoDePersona == Persona.TipoPersona.Huesped)
            {
                StreamWriter archivo = new StreamWriter("Factura.txt");


                seguro = 0.025 * rsv.Habitacion.Precio;

                totalNoches = rsv.Habitacion.Precio * (rsv.Dias - 1);

                subtotal = seguro + totalNoches + totalProductosXHab + totalServiciosXHab;

                total = subtotal * IVA;
                

                archivo.WriteLine("A continuación se generará su factura para la habitación: {0}", rsv.Habitacion.NumHabitacion.ToString()); ;
                archivo.WriteLine("Total por noches en {0} es: ${1} ", (rsv.Dias - 1), totalNoches.ToString());
                archivo.WriteLine("El total de los productos consumidos es: ${0}", totalProductosXHab.ToString());
                archivo.WriteLine("El total de los servicios utilizados es: ${0}", totalServiciosXHab.ToString());
                archivo.WriteLine("El seguro es de: ${0}", seguro.ToString());
                archivo.WriteLine("El Subtotal es: ${0}", subtotal.ToString());
                archivo.WriteLine();                
                archivo.WriteLine("EL TOTAL A PAGAR ES: ${0}", total.ToString());

                archivo.Close();
            }

            
        }
        
    }
}
