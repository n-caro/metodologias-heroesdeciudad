using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class ProtocoloRCP
    {
        public void realizarRCP(IInfartable paciente)
        {
            this.eliminarObjetosDeBoca();
            this.comprobarEstadoConsciente();
            if (!paciente.estasConsciente())
            {
                this.llamarAmbulancia();
                this.descubrirToraxPaciente();
                this.acomodarCabezaPaciente();
                this.repetirHastaQueRespire(paciente);
            }
            else
            {
                Console.WriteLine("     EL PACIENTE YA SE ENCUENTRA CONSCIENTE");
            }
        }

        // Métodos
        abstract protected void repetirHastaQueRespire(IInfartable paciente);

        abstract protected void eliminarObjetosDeBoca(); //1
        abstract protected void comprobarEstadoConsciente(); //2
        abstract protected void llamarAmbulancia(); //3
        abstract protected void descubrirToraxPaciente(); //4
        abstract protected void acomodarCabezaPaciente(); //5
        abstract protected void hacerCompresionesToracicas(); //6
        abstract protected void hacerInsuflaciones(); //7
        abstract protected void usarDesfibrilador(); //8
    }
}
