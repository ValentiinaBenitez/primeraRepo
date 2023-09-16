using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Remito remito1 = new Remito(12, "13 de mayo", 10);
            Impresora i1 = new Impresora();
            i1.imprimir(remito1);

            Factura factura1 = new Factura("5 de septiembre", 300);
            Impresora i2 = new Impresora(); 
            i2.imprimir(factura1);

            FacturaLuz facturaLuz1 = new FacturaLuz(4117, 1200);
            Impresora i3 = new Impresora();
            i3.imprimir(facturaLuz1);

            Municipal municipal1 = new Municipal(2000, 65);
            Impresora i4 = new Impresora();
            i4.imprimir(municipal1);

            ReciboSueldo reciboSueldo1 = new ReciboSueldo(3, 40000);
            Impresora i5 = new Impresora();
            i5.imprimir(reciboSueldo1);

            remito1.setCantBultos(20);
            remito1.setFecha("22 de junio");
            remito1.setNúmero(4);
            Impresora i6 = new Impresora();
            i6.imprimir(remito1);

        }
    }

}
