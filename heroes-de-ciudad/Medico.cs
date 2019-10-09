using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Medico: IResponsable
    {
        ProtocoloRCP protocoloRCP;
        private IHerramienta herramienta;
        private IVehiculo vehiculo;

        // getters-setters
        public IHerramienta getHerramienta() { return herramienta; }
        public void setHerramienta(IHerramienta herramienta) { this.herramienta = herramienta; }
        public IVehiculo getVehiculo() { return vehiculo; }
        public void setVehiculo(IVehiculo vehiculo) { this.vehiculo = vehiculo; }

        // Métodos
        public void atenderInfarto(IInfartable paciente)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡Se me ha solicitado atender un infarto!] ");
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            Console.ForegroundColor = ConsoleColor.White;

            protocoloRCP.realizarRCP(paciente);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡He finalizado el protocolo RCP!] ");
            herramienta.guardar();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void atenderDesmayo()
        {
            Console.WriteLine("¡Estoy atendiendo un desmayo!");
        }

        // Constructores
        public Medico(ProtocoloRCP protocoloRCP)
        {
            this.protocoloRCP = protocoloRCP;
        }
        public Medico()
        {
            this.protocoloRCP = new RCPTipoA();
        }

    }
}
