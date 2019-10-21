using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class RCPTipoA : ProtocoloRCP
    {
        // Métodos
        protected override void repetirHastaQueRespire(IInfartable paciente)
        {
            while (!paciente.estasRespirando())
            {
                this.hacerCompresionesToracicas();
                this.hacerInsuflaciones();
                if (!paciente.tenesRitmoCardiaco())
                {
                    this.usarDesfibrilador();
                }
            }
            Console.WriteLine("     EL PACIENTE YA ESTÁ RESPIRANDO");
        }


        override protected void eliminarObjetosDeBoca()
        {
            Console.WriteLine("     Elimino objetos que obstruyen las vías respiratorias");
        }
        override protected void comprobarEstadoConsciente()
        {
            Console.WriteLine("     Compruebo el estado de consciencia del paciente");
        }
        override protected void llamarAmbulancia()
        {
            Console.WriteLine("     Llamo a una ambulancia.");
        }
        override protected void descubrirToraxPaciente()
        {
            Console.WriteLine("     Descubro el torax del paciente.");
        }
        override protected void acomodarCabezaPaciente()
        {
            Console.WriteLine("     Acomodo cabeza del paciente");
        }
        override protected void hacerCompresionesToracicas()
        {
            Console.WriteLine("     Hago compresiones torácicas");
        }
    override protected void hacerInsuflaciones()
        {
            Console.WriteLine("     Hago Insuflaciones");
        }
        override protected void usarDesfibrilador()
        {
            Console.WriteLine("     Uso desfibrilador");
        }
    }
}
