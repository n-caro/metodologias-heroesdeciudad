using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class HeroesDeCiudad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     #Testing de Heroes \n ---------------------- ");

            Bombero bombero = new Bombero();
            Medico medico = new Medico();
            Policia policia = new Policia();
            Electricista electricista = new Electricista();
            Mecanico mecanico = new Mecanico();

            Console.WriteLine("\n #Bombero:");
            bombero.apagarIncendio();
            bombero.bajarGatitoArbol();

            Console.WriteLine("\n #Medico:");
            medico.atenderDesmayo();
            medico.atenderInfarto();

            Console.WriteLine("\n #Policia:");
            policia.patrullar();
            policia.detenerDelincuente();

            Console.WriteLine("\n #Electricista:");
            electricista.revisar();

            Console.WriteLine("\n #Mecanico:");
            mecanico.arreglarMotor();
            mecanico.remolcarAuto();
            // Testing de 02 - Strategy

        }
    }
}
