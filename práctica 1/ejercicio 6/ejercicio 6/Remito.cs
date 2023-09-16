using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    internal class Remito
    {
        private int cantBultos;
        private string fecha;
        private int número;

        public Remito(int cantBultos, string fecha, int número)
        {
            this.cantBultos = cantBultos;
            this.fecha = fecha;
            this.número = número;
        }

      
        public int getCantBultos()
        {
            return cantBultos;
        }

        public string getFecha()
        {
            return fecha;
        }

        public int getNúmero()
        {
            return número;
        }

        public void setCantBultos(int cantBultos)
        {
            this.cantBultos = cantBultos;
        }

        public void setFecha(string fecha)
        {
            this.fecha = fecha;
        }

        public void setNúmero(int número)
        {
            this.número = número;
        }
    }
}
