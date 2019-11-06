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
            // Creo mensajes de inicialización de apagado en consola
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("     [BOMBERO]       ");
            Console.ResetColor();
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            Console.WriteLine("# [Apagando Incendio] [Lugar: {0}] [Estrategia: {1}]", lugar, estrategiaApagado);
            // dejo a cargo MI Strategy de recorrer la matriz
            estrategiaApagado.apagarIncendio(lugar);
           // herramientas
            herramienta.guardar();
            Console.WriteLine("_______________________________________________ \n ");
        }

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        // 03 - Observer
        public void actualizar(ILugar lugar)
        {
            Console.WriteLine("# BOMBERO: He recibido un aviso de Alarma de Incendio! Socorriendo Lugar a continuación ");
            apagarIncendio(lugar);
        }

    }
}
