using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Bombero: Responsable, IAlarmaIncendioObserver, IResponsable
    {
        private IEstrategiaDeApagado estrategiaApagado = new ApagadoSecuencial();

        // getters-setters

        public void setEstrategiaApagado(IEstrategiaDeApagado estrategiaApagado)
        {
            this.estrategiaApagado = estrategiaApagado;
        }

        // Métodos
        override public void apagarIncendio(ILugar lugar)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     [BOMBERO]       ");
            Console.ResetColor();
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            Console.WriteLine("# [Apagando Incendio] [Lugar: {0}] [Estrategia: {1}]", lugar, estrategiaApagado);
            estrategiaApagado.RecorrerLugar(lugar, lugar.getCalle());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ResetColor();
            herramienta.guardar();
            Console.WriteLine("_______________________________________________ \n ");
        }

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        public void actualizar(ILugar lugar)
        {
            Console.WriteLine("# BOMBERO: He recibido un aviso de Alarma de Incendio! Socorriendo Lugar a continuación ");
            apagarIncendio(lugar);
        }

        // Chain of Responsability
        public Bombero(IResponsable r): base(r)
        {

        }
        public Bombero() : base(null)
        {

        }
        // end Chain of responsability
    }
}
