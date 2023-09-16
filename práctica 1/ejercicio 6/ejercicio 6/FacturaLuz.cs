using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class FacturaLuz
    {
        private int codigoPago;
        private int importe;

        public FacturaLuz(int codigoPago, int importe)
        {
            this.codigoPago = codigoPago;
            this.importe = importe;
        }

        //--------------------------------------------------------
        public int getCodigoPago()
        {
            return codigoPago;
        }

        public int getImporte()
        {
            return importe;
        }

        public void setCodigoPago(int codigoPago)
        {
            this.codigoPago = codigoPago;
        }

        public void setImporte(int importe)
        {
            this.importe = importe;
        }
    }
}
