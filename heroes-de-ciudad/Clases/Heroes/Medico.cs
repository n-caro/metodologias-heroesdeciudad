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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("     [MEDICO]       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# [¡Se me ha solicitado atender un infarto!] ");
            Console.ResetColor();
            vehiculo.encenderSirena();
            vehiculo.conducir();
            herramienta.usar();
            protocoloRCP.realizarRCP(paciente);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("# [¡He finalizado el protocolo RCP!] ");
            Console.ResetColor();
            herramienta.guardar();
            Console.WriteLine("_______________________________________________ \n ");
        }

        public void atenderDesmayo()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("     [MEDICO]       ");
            Console.ResetColor();
            Console.WriteLine("¡Estoy atendiendo un desmayo!");
            Console.WriteLine("_______________________________________________ \n ");
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
