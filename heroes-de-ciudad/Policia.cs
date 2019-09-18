using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Policia
    {
        IOrdenPolicia ordenPolicia = null;

        // Métodos
        public void patrullarCalles(IPatrullable lugarAPatrullar)
        {
            Console.WriteLine("[POLICIA] ¡Estoy patrullando! [Lugar: {0} ]", lugarAPatrullar);
            if (lugarAPatrullar.hayAlgoFueraDeLoNormal())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    HAY UNA AMENAZA PARA LA SEGURIDAD!");
                Console.ForegroundColor = ConsoleColor.Blue;
                ordenPolicia.Ejecutar();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void detenerDelincuente()
        {
            Console.WriteLine("¡Estoy deteniendo un delincuente!");
        }

        public IOrdenPolicia OrdenPolicia {
            set { ordenPolicia = value; }
            }
    }
}
