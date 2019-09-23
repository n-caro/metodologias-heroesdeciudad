using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Medico
    {
        public void atenderInfarto(IInfartable paciente)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡Se me ha solicitado atender un infarto!] ");
            Console.ForegroundColor = ConsoleColor.White;
            ProtocoloRCP protocoloRCP = new RCPTipoB();
            protocoloRCP.realizarRCP(paciente);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡He finalizado el protocolo RCP!] ");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void atenderDesmayo()
        {
            Console.WriteLine("¡Estoy atendiendo un desmayo!");
        }
        // Constructores
        public Medico() {}

    }
}
