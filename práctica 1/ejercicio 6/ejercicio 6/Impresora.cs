using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Impresora
    {
        public void imprimir(Remito remito)
        {
            Console.WriteLine("La cantidad de bultos es " + remito.getCantBultos() + ", la fecha es " + remito.getFecha() + " y el número es " + remito.getNúmero());
        }
        public void imprimir(Factura factura)
        {
            Console.WriteLine("La fecha de la factura es " + factura.getFecha() + " y el importe es de " + factura.getImporte());
        }

        public void imprimir(FacturaLuz factura)
        {
            Console.WriteLine("El código de la factura de la luz es " + factura.getCodigoPago() + " y el importe es de " + factura.getImporte());
        }

        public void imprimir(Municipal municipal)
        {
            Console.WriteLine("El importe del municipal es " + municipal.getImporte() + " y la partida es " + municipal.getPartida());
        }

        public void imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine("El legajo del recibo de sueldo es " + reciboSueldo.getLegajo() + " y el total es de " + reciboSueldo.getTotal());
        }
    }
}
