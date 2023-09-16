using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Factura
    {
        private string fecha;
        private int importe;

        public Factura(string fecha, int importe)
        {
            this.fecha = fecha;
            this.importe = importe;
        }

        //--------------------------------------------------------
        public string getFecha()
        {
            return fecha;
        }

        public int getImporte()
        {
            return importe;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public void setImporte(int importe)
        {
            this.importe = importe;
        }
    }
}
