using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Alaska", 1);
            Alumno alumno3 = new Alumno("Odin");

            alumno1.imprimirEdadNombre(alumno1);
            alumno3.imprimirNombre(alumno3);

        }
    }

    class Alumno
    {
        private string alumno;
        private int edad;

        //metodos
        public Alumno(string alumno)
        {
            this.alumno = alumno; 
        }
        public Alumno(string alumno, int edad)
        {
            this.alumno = alumno;
            this.edad = edad;
        }

        //getter
        public string getAlumno()
        {
            return alumno;
        }
        public int getEdad()
        {
            return edad;
        }

        public void imprimirEdadNombre(Alumno alumno)
        {
            Console.WriteLine("El nombre del alumno es: " + alumno.getAlumno() + " y la edad es: " + alumno.getEdad());
        }

        public void imprimirNombre(Alumno alumno)
        {
            Console.WriteLine("El nombre del alumno es: " + alumno.getAlumno());
        }

    }
}
