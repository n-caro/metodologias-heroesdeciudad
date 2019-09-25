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

            Electricista electricista = new Electricista();

            // manzana es 4 esquinas y 4 calles
            Esquina esquina1 = new Esquina(1);
            Esquina esquina2 = new Esquina(2);
            Esquina esquina3 = new Esquina(3);
            Esquina esquina4 = new Esquina(4);
            Calle calle1 = new Calle(100, 5, 50);
            Calle calle2 = new Calle(100, 5, 50);
            Calle calle3 = new Calle(100, 5, 50);
            Calle calle4 = new Calle(100, 5, 50);

            IluminableCompuesto unaManzana = new IluminableCompuesto("Manzana");
            unaManzana.agregarHijo(esquina1);
            unaManzana.agregarHijo(esquina2);
            unaManzana.agregarHijo(esquina3);
            unaManzana.agregarHijo(esquina4);
            unaManzana.agregarHijo(calle1);
            unaManzana.agregarHijo(calle2);
            unaManzana.agregarHijo(calle3);
            unaManzana.agregarHijo(calle4);

            electricista.cambiarLamparasQuemadas(unaManzana);

            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
