using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class ReciboSueldo
    {
        private int legajo;
        private int total;

        public ReciboSueldo(int legajo, int total)
        {
            this.legajo = legajo;
            this.total = total;
        }

        //--------------------------------------------------------
        public int getLegajo()
        {
            return legajo;
        }

        public int getTotal()
        {
            return total;
        }

        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        public void setTotal(int total)
        {
            this.total = total;
        }
    }
}
