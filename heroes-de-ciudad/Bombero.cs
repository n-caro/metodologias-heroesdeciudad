using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Bombero
    {
        private EstrategiaDeApagado estrategiaApagado = new ApagadoSecuencial();


        public EstrategiaDeApagado setEstrategiaApagado
        {
            set
            {
                estrategiaApagado = value;
            }
        }

        public void apagarIncendio(ILugar lugar, Calle calle)
        {
            Console.WriteLine("[Apagando Incendio!]");
            estrategiaApagado.RecorrerLugar(lugar, calle);
            Console.WriteLine("¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
        }

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        
    }
}
