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
            Calle calle = new Calle(100, 10, 30);
            bombero.setEstrategiaApagado = new ApagadoEspiral();

            Casa casa = new Casa(10, 9, 10, calle);
            Plaza plazaPrincipal = new Plaza("Plaza Principal", 9, 10, 10, calle);



            bombero.apagarIncendio(plazaPrincipal, plazaPrincipal.getCalle());

            bombero.apagarIncendio(casa, casa.getCalle());
            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
