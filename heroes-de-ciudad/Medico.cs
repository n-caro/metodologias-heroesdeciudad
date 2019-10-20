using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Medico: Responsable, IResponsable
    {
        ProtocoloRCP protocoloRCP = new RCPTipoA();
       
        public void setProtocoloRCP(ProtocoloRCP protocolo)
        {
            protocoloRCP = protocolo;
        }

        // Métodos
        override public void atenderInfarto(IInfartable paciente)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡Se me ha solicitado atender un infarto!] ");
            //vehiculo.encenderSirena();
            //vehiculo.conducir();
            //herramienta.usar();
            Console.ForegroundColor = ConsoleColor.White;

            protocoloRCP.realizarRCP(paciente);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# MEDICO: [¡He finalizado el protocolo RCP!] ");
            //herramienta.guardar();
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void atenderDesmayo()
        {
            Console.WriteLine("¡Estoy atendiendo un desmayo!");
        }

        // Chain of Responsability
        public Medico(IResponsable r) : base(r)
        {

        }
        public Medico() : base(null)
        {

        }
        // end Chain of responsability

    }
}
