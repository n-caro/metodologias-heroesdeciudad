using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class RCPTipoB : ProtocoloRCP
    {

        // Métodos
        protected override void repetirHastaQueRespire(IInfartable paciente)
        {
            int intentos = 0;
            while (!paciente.estasRespirando() && (intentos != 5))
            {
                this.hacerCompresionesToracicas();
                this.hacerInsuflaciones();
                if (!paciente.tenesRitmoCardiaco())
                {
                    this.usarDesfibrilador();
                }
                intentos++;
            }
            if (intentos == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    Se han realizado 5 intentos y el paciente no respira. Desisto con la rehanimación, el paciente ha fallecido");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("     EL PACIENTE YA RESPIRA");
            }
        }


        override protected void eliminarObjetosDeBoca()
        {
            Console.WriteLine("     Eliminando objetos que obstruyen las vías respiratorias");
        }
        override protected void comprobarEstadoConsciente()
        {
            Console.WriteLine("     Comprobando el estado de consciencia del paciente");
        }
        override protected void llamarAmbulancia()
        {
            Console.WriteLine("     Llamando a una ambulancia.");
        }
        override protected void descubrirToraxPaciente()
        {
            Console.WriteLine("     Descubriendo el torax del paciente.");
        }
        override protected void acomodarCabezaPaciente()
        {
            Console.WriteLine("     Acomodando cabeza del paciente");
        }
        override protected void hacerCompresionesToracicas()
        {
            Console.WriteLine("     Haciendo compresiones torácicas");
        }
        override protected void hacerInsuflaciones()
        {
            Console.WriteLine("     Haciendo Insuflaciones");
        }
        override protected void usarDesfibrilador()
        {
            Console.WriteLine("     Usando desfibrilador");
        }
    }
}
