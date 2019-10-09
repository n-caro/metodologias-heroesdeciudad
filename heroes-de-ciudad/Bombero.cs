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
        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        // getters-setters
        public IHerramienta getHerramienta() {return herramienta; }
        public void setHerramienta(IHerramienta herramienta) { this.herramienta = herramienta; }
        public IVehiculo getVehiculo() { return vehiculo; }
        public void setVehiculo(IVehiculo vehiculo) { this.vehiculo = vehiculo; }

        public IEstrategiaDeApagado setEstrategiaApagado
        {
            set
            {
                estrategiaApagado = value;
            }
        }

        // Métodos
        public void apagarIncendio(ILugar lugar)
        {
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            Console.WriteLine("# BOMBERO: [Apagando Incendio] [Lugar: {0}] [Estrategia: {1}]", lugar, estrategiaApagado);
            estrategiaApagado.RecorrerLugar(lugar, lugar.getCalle());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ForegroundColor = ConsoleColor.White;
            herramienta.guardar();
        }

        /*public void apagarIncendio(ILugar lugar)
        {
            this.apagarIncendio(lugar, lugar.getCalle());
        }*/

        public void bajarGatitoArbol()
        {
            Console.WriteLine("¡Estoy bajando al gatito del árbol!");
        }

        public void actualizar(ILugar lugar)
        {
            Console.WriteLine("# BOMBERO: He recibido un aviso de Alarma de Incendio! Socorriendo Lugar a continuación ");
            apagarIncendio(lugar);
        }

    }
}
