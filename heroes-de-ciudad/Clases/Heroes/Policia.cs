using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Policia: Responsable, IResponsable
    {
        IOrdenPolicia ordenPolicia = new OPVozDeAlto();

        // getters-setters
        public void setOrdenPolicia(IOrdenPolicia ordenPolicia)
        {
            this.ordenPolicia = ordenPolicia;
        }

        // Métodos
        override public void patrullarCalles(IPatrullable lugarAPatrullar)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("     [POLICIA]       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[POLICIA] ¡Estoy patrullando! [Lugar: {0} ]", lugarAPatrullar);
            Console.ResetColor();
            vehiculo.encenderSirena();
            vehiculo.conducir();
            if (lugarAPatrullar.hayAlgoFueraDeLoNormal())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    HAY UNA AMENAZA PARA LA SEGURIDAD!");
                Console.ForegroundColor = ConsoleColor.Blue;
                herramienta.usar();
                ordenPolicia.Ejecutar();
                Console.ResetColor();
                herramienta.guardar();
            }
            else
            {
                Console.WriteLine("No hay nada fuera de lo normal");
            }
            Console.ResetColor();
            Console.WriteLine("_______________________________________________ \n ");
        }

        public void detenerDelincuente()
        {
            Console.WriteLine("¡Estoy deteniendo un delincuente!");
        }

    }
}
