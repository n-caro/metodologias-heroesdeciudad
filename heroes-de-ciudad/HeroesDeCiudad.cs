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
            Calle callePrincipal = new Calle(100, 10, 50);
            Casa casa01 = new Casa(10, 4, 10, callePrincipal);
            Casa casa02 = new Casa(10, 10, 10, callePrincipal);
            Plaza Plaza01 = new Plaza("Ricardo", 50, 10, 10, callePrincipal);
            // Pruebo incendios
            casa01.agregarObservador(bombero);
            Plaza01.agregarObservador(bombero);
            casa01.chispa();
            bombero.apagarIncendio();
            // Se incendia la plaza
            Plaza01.chispa();
            bombero.setEstrategiaApagado = new ApagadoEspiral();
            bombero.apagarIncendio();

            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
