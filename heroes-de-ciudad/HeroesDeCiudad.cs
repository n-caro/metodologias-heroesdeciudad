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

            Policia policiaGutierrez = new Policia();

            // creo colección al azar
            List<IPatrullable> lugaresAPatrullar = new List<IPatrullable>(15);
            Calle calle01 = new Calle(100, 10, 50);
            Calle calle02 = new Calle(150, 10, 80);
            for (int i = 0; i < 15; i++)
            {
                if(i%2 == 0)
                {
                    lugaresAPatrullar.Add(new Casa(i * 2 + 1, i * 2 + 5, i * 2 + 1, calle02));
                }
                else
                {
                    lugaresAPatrullar.Add(new Plaza("Plaza Random" + i, i * 3 + 10, i + 15, i + 10, calle01));
                }
            }

            // Patrullo los diversos lugares
            for(int pos = 0; pos < 15; pos++)
            {
                if(pos == 0)
                {
                    policiaGutierrez.OrdenPolicia = new OPVozDeAlto();
                }
                if (pos == 5)
                {
                    policiaGutierrez.OrdenPolicia = new OPPerseguirYArrestar();
                }
                if (pos == 9)
                {
                    policiaGutierrez.OrdenPolicia = new OPAvisarYPedirRefuerzos();
                }
                Console.WriteLine("ITERACION " + (pos+1) + "-------------------" );
                policiaGutierrez.patrullarCalles(lugaresAPatrullar[pos]);
            }

            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
