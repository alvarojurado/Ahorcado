using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Ahorcado
    {
        private char[] palabra;
        private char[] actual;
        private int intentos = 6;
        bool victoria = false;

        public char[] Palabra { get => palabra; set => palabra = value; }
        public char[] Actual { get => actual; set => actual = value; }
        public int Intentos { get => intentos; set => intentos = value; }
        public bool Victoria { get => victoria; set => victoria = value; }

        public Ahorcado(string palabra)
        {

            this.Palabra = new char[palabra.Length];
            actual = new char[palabra.Length];
            this.Palabra=(palabra.ToCharArray());
            for (int i = 0; i < Actual.Length; i++)
            {
                Actual[i] = '_';

            }
        }

        public void Interfaz1()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                              _________________                ");
            Console.WriteLine("            VIDAS: 0          |                |               ");
            Console.WriteLine("                              |                |               ");
            Console.WriteLine("                              |                O               ");
            Console.WriteLine("                              |            ----|----           ");
            Console.WriteLine("                              |               / \\             ");
            Console.WriteLine("                              |              /   \\            ");
            Console.WriteLine("                          ____|____                            ");
            Console.WriteLine("         ================================================================================");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        static public void Interfaz2()

        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                              _________________                ");
            Console.WriteLine("            VIDAS: 1          |                |               ");
            Console.WriteLine("                              |                |               ");
            Console.WriteLine("                              |                O               ");
            Console.WriteLine("                              |            ----|----           ");
            Console.WriteLine("                              |               /              ");
            Console.WriteLine("                              |              /               ");
            Console.WriteLine("                          ____|____                            ");
            Console.WriteLine("         ================================================================================");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        static public void Interfaz3()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                              _________________                ");
            Console.WriteLine("            VIDAS: 2          |                |               ");
            Console.WriteLine("                              |                |               ");
            Console.WriteLine("                              |                O               ");
            Console.WriteLine("                              |            ----|----           ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                              |                            ");
            Console.WriteLine("                          ____|____                            ");
            Console.WriteLine("         ================================================================================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        static public void Interfaz4()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                              _________________                ");
            Console.WriteLine("            VIDAS: 3          |                |               ");
            Console.WriteLine("                              |                |               ");
            Console.WriteLine("                              |                O               ");
            Console.WriteLine("                              |            ----|           ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                          ____|____                            ");
            Console.WriteLine("         ================================================================================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        static public void Interfaz5()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                              _________________                ");
            Console.WriteLine("            VIDAS: 4          |                |               ");
            Console.WriteLine("                              |                |               ");
            Console.WriteLine("                              |                O               ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                              |                             ");
            Console.WriteLine("                          ____|____                            ");
            Console.WriteLine("         ================================================================================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public void Interfaz6()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("         ================================================================================");
            Console.WriteLine("                               _________________                ");
            Console.WriteLine("            VIDAS: 5           |                               ");
            Console.WriteLine("                               |                               ");
            Console.WriteLine("                               |                               ");
            Console.WriteLine("                               |                             ");
            Console.WriteLine("                               |                             ");
            Console.WriteLine("                               |                              ");
            Console.WriteLine("                           ____|____                            ");
            Console.WriteLine("         ================================================================================");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

        }
        public void EscribirActual(char letra)
        {
            
            Console.Clear();
            bool encontrado = false;
      
            for (int i = 0; i < palabra.Length; i++)
            {
         
                if (Palabra[i].Equals(letra)) {
                    actual[i] = palabra[i];
                    encontrado = true;
                }
            }

            if(!encontrado){
                intentos--;
            }
            if (!actual.Contains('_'))
            {
                Victoria = true;
            }
        }
        public void IntroducirLetra()
        {
            char letra;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     Introduzca letra: ");
            letra = Console.ReadKey().KeyChar;
            EscribirActual(letra);

        }
        public void imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                                  ");
            for (int i = 0; i < actual.Length; i++)
            {

                Console.Write(" " + actual[i] + " ");
            }
            IntroducirLetra();
        }
        public void Iniciar()
        {
            while (intentos == 6 && !Victoria)
            {
                Interfaz6();
                imprimir();
            }
            while(intentos == 5 && !Victoria)
            {
                Interfaz5();
                imprimir();
            }
            while (intentos == 4 && !Victoria)
            {
                Interfaz4();
                imprimir();
            }
            while (intentos == 3 && !Victoria)
            {
                Interfaz3();
                imprimir();
            }
            while (intentos == 2 && !Victoria)
            {
                Interfaz2();
                imprimir();
            }
            while (intentos == 1 && !Victoria)
            {
                Interfaz1();
                imprimir();
            }
            

        }
    }

    }
    
