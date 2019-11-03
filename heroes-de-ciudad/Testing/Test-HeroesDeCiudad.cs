using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad.Testing
{
    class Test_HeroesDeCiudad
    {

        public static void tituloDecorado()
        {
            Console.WriteLine("     --- H E R O E S  D E  C I U D A D ---       ");
            infoHeroes();
            Console.WriteLine("\n");
        }

        // Información de heroes
        private static void infoHeroes()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write(" [BOMBERO] ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" [POLICIA] ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" [MEDICO] ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" [ELECTRICISTA] ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" [MECANICO  \n");
            Console.ResetColor();
        }

 

    }
}
