using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Bombero: IAlarmaIncendioObserver, IResponsable
    {
        private IEstrategiaDeApagado estrategiaApagado = new ApagadoSecuencial();

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

        public void apagarIncendio(ILugar lugar)
        {
            this.apagarIncendio(lugar, lugar.getCalle());
        }

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        public void actualizar(ILugar lugar)
        {
            Console.WriteLine("# BOMBERO: He recibido un aviso de Alarma de Incendio! Socorriendo Lugar a continuación ");
            apagarIncendio(lugar, lugar.getCalle());
        }

        // De IResponsable
        public void atenderDenuncia(IDenuncia denuncia)
        {
            Console.WriteLine("<Voy a atender una denuncia de incendio>");
            apagarIncendio(denuncia.getLugar());
        }

    }
}
