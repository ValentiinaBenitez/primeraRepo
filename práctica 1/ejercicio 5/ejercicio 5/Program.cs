using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            //creación y asignación de valores 
            Console.WriteLine("Primera matriz");
            Matriz[,] matriz1 = new Matriz[2,2];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine("Escriba el valor del número");
                    numero = Convert.ToInt32(Console.ReadLine());
                    matriz1[i, j] = new Matriz(numero);
                }
            }


            Console.WriteLine("Segunda matriz");
            Matriz[,] matriz2 = new Matriz[2, 2];

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine("Escriba el valor del número");
                    numero = Convert.ToInt32(Console.ReadLine());
                    matriz2[i, j] = new Matriz(numero);
                }
            }

            // Sumar matrices
            Matriz[,] matrizResultado = new Matriz[2, 2];
            int numero1;
            for (int i = 0; i < matrizResultado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultado.GetLength(1); j++)
                {
                    numero1 = int.Parse(matriz1[i, j].getInfo()) + int.Parse(matriz2[i, j].getInfo());
                    matrizResultado[i, j] = new Matriz(numero1);
                }
            }

            Console.WriteLine("Suma de las matrices:");
            // ver la matriz resultado
            for (int i = 0; i < matrizResultado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultado.GetLength(1); j++)
                {
                    Console.Write($" {matrizResultado[i, j].getInfo()}");
                }
                Console.WriteLine("");
            }
            
        }
    }

    class Matriz
    {
        private int d;
        public Matriz(int d)
        {
            this.d = d;
        }

        public string getInfo()
        {
             return $"{d}";
        }
     
    }

   


    
}
