using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Bombero: IAlarmaIncendioObserver
    {
        private IEstrategiaDeApagado estrategiaApagado = new ApagadoSecuencial();

        /* Cola de incendios
        private Queue<ILugar> colaIncendios = new Queue<ILugar>();
        */

        // getters-setters

        public IEstrategiaDeApagado setEstrategiaApagado
        {
            set
            {
                estrategiaApagado = value;
            }
        }

        // Métodos
        public void apagarIncendio(ILugar lugar, Calle calle)
        {
            Console.WriteLine("# BOMBERO: [Apagando Incendio] [Lugar: {0}] [Estrategia: {1}]", lugar, estrategiaApagado);
            estrategiaApagado.RecorrerLugar(lugar, calle);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        public void actualizar(ILugar lugar)
        {
            apagarIncendio(lugar, lugar.getCalle());
            /* Cola de incendios
            apagarIncendio(Lugar)
            */
        }

        /* Cola de incendios
        public void apagarIncendio(ILugar lugar)
        {

 
            if(colaIncendios.Count == 0)
            {
                Console.WriteLine("No hay incendios pendientes a tratar.");
            }
            else
            {
                ILugar lugar = colaIncendios.Dequeue();
                apagarIncendio(lugar, lugar.getCalle());
            }
            */
    }
}
