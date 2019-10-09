using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciaDeRobo: IDenuncia
    {
        IPatrullable patrullable;

        public void atender(IResponsable policia)
        {
            Policia p = (Policia)policia;
            p.patrullarCalles(patrullable);

        }

        public IPatrullable getPatrullable()
        {
            return patrullable;
        }
        // Constructor

        public DenunciaDeRobo(IPatrullable patrullable)
        {
            this.patrullable = patrullable;
        }
    }
}
