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

            Medico medico = new Medico();

            Transeunte transeunte = new Transeunte(0.9, 0.9, 0.9);
            medico.atenderInfarto(transeunte);
            Passerby passerby = new Passerby(0.5, 0.5, 0.1);
            IInfartable adaptador = new InfartableAdapter(passerby);
            medico.atenderInfarto(adaptador);
            


            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
