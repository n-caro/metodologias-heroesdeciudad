using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciaDeInfarto : IDenuncia
    {
        IInfartable paciente;

        public void atender(IResponsable medico)
        {
            Medico m = (Medico)medico;
            m.atenderInfarto(paciente);

        }

        //setters-getters
        public IInfartable getPacienter()
        {
            return paciente;
        }
        // Constructor

        public DenunciaDeInfarto(IInfartable paciente)
        {
            this.paciente = paciente;
        }
    }
}
