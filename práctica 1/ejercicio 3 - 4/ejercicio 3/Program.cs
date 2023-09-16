using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cree el primer vector");
            Console.Write("Primer valor: ");
            int primerValor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int segundoValor = Convert.ToInt32(Console.ReadLine());
            Vector vectorUno = new Vector(primerValor, segundoValor);

            Console.WriteLine("Cree el segundo vector");
            Console.Write("Primer valor: ");
            primerValor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo valor: ");
            segundoValor = Convert.ToInt32(Console.ReadLine());
            Vector vectorDos = new Vector(primerValor, segundoValor);

            int SumaX = (vectorUno.getX() + vectorDos.getX());
            int SumaY = (vectorUno.getY() + vectorDos.getY());

            int RestaX = (vectorUno.getX() - vectorDos.getX());
            int RestaY = (vectorUno.getY() - vectorDos.getY());

            Console.WriteLine("La suma de los vector es (" + SumaX + ", " + SumaY + ")");
            Console.WriteLine("La resta de los vector es (" + RestaX + ", " + RestaY + ")");

            int distanciaVectorX = vectorDos.getX() - vectorUno.getX();
            int distanciaVectorY = vectorDos.getY() - vectorUno.getY();

            double moduloVector = Math.Sqrt((distanciaVectorX * distanciaVectorX) + (distanciaVectorY * distanciaVectorY));
            Console.WriteLine("La distancia entre los puntos de los vectores es de " + moduloVector);
        }
    }
    
    class Vector
    {
        private int x;
        private int y;

        public Vector (int x, int y)
        {
            this.x = x; 
            this.y = y;
        }

        public int getX ()
        {
            return x;
        }
        public int getY ()
        {
            return y;
        }


    }
}
