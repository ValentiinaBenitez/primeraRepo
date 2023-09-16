using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Auto auto2 = new Auto(3.6, 2.4);
            Auto auto3 = new Auto("blanco", 2022);

            Console.WriteLine("AUTO 1 - Climatizador: " + auto1.getClimatizador() + " / Tapicería: " + auto1.getTapicería());
            Console.WriteLine("AUTO 2 - Climatizador: " + auto2.getClimatizador() + " / Tapicería: " + auto2.getTapicería());
            Console.WriteLine("AUTO 3 - Climatizador: " + auto3.getClimatizador() + " / Tapicería: " + auto3.getTapicería());

            auto1.setClimatizadorTapicería(true, "algodón");
            auto3.setClimatizadorTapicería(true, "microfibra");

            Console.WriteLine("AUTO 1 - Climatizador: " + auto1.getClimatizador() + " / Tapicería: " + auto1.getTapicería());
            Console.WriteLine("AUTO 3 - Climatizador: " + auto3.getClimatizador() + " / Tapicería: " + auto3.getTapicería());
        }
    }
    class Auto
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapicería;
        private string color;
        private int año;

        public Auto()
        {
            ruedas = 4;
            largo = 3;
            ancho = 2;
            climatizador = false;
            tapicería = "tela";
            color = "negro";
            año = 2021;
        }

        public Auto(double largo, double ancho)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            climatizador = true;
            tapicería = "tela";
            color = "negro";
            año = 2021;
        }

        public Auto(string color, int año)
        {
            ruedas = 4;
            largo = 3;
            ancho = 2;
            climatizador = false;
            tapicería = "tela";
            this.color = color;
            this.año = año;

        }

        public bool getClimatizador()
        {
            return climatizador;
        }

        public string getTapicería()
        {
            return tapicería;
        }


        public void setClimatizadorTapicería(bool climatizador, string tapicería) 
        {
            this.climatizador = climatizador;
            this.tapicería = tapicería;
        }


    }

    }
