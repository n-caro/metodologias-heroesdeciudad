using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciaDeLamparaQuemada : IDenuncia
    {
        IIluminable iluminable;

        public void atender(IResponsable electricista)
        {
            Electricista e = (Electricista)electricista;
            e.cambiarLamparasQuemadas(iluminable);

        }

        public IIluminable getIluminable()
        {
            return iluminable;
        }
        // Constructor

        public DenunciaDeLamparaQuemada(IIluminable iluminable)
        {
            this.iluminable = iluminable;
        }
    }
}
