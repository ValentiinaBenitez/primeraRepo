using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Municipal
    {
        private int importe;
        private int partida;

        public Municipal(int importe, int partida)
        {
            this.importe = importe;
            this.partida = partida;
        }

        //--------------------------------------------------------
        public int getImporte()
        {
            return importe;
        }

        public int getPartida()
        {
            return partida;
        }

        public void setImporte(int importe)
        {
            this.importe = importe;
        }

        public void setPartida(int partida)
        {
            this.partida = partida;
        }
    }
}
