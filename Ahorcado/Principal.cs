using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class Principal
    {
        static void Main(string[] args)
        {
            string pal;
            while (true)
            {
                Console.WriteLine("            El juego del ahorcado    ");
                Console.WriteLine();
                Console.WriteLine("            Introduzca la palabra: ");
                pal = Console.ReadLine();
                Ahorcado ah = new Ahorcado(pal);
                Console.Clear();
                ah.Iniciar();
                if (ah.Victoria)
                {
                    Console.WriteLine();
                    Console.WriteLine("            Has ganado pulsa cualquier boton para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("            Has perdido pulsa cualquier boton para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    }
}

