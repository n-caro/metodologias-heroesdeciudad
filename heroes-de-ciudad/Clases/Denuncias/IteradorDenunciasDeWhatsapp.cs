using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class IteradorDenunciasDeWhatsapp: IteradorDeDenucias
    {
        private MensajeWhatsapp mensajeWhatsapp;

        public IteradorDenunciasDeWhatsapp(MensajeWhatsapp mensajeWpp)
        {
            mensajeWhatsapp = mensajeWpp;
        }

        public IDenuncia actual()
        {
            return mensajeWhatsapp.getDenuncia();
        }

        public void siguiente()
        {
            mensajeWhatsapp = mensajeWhatsapp.getSiguiente();
        }

        public bool fin()
        {
            return mensajeWhatsapp == null;
        }
    }
}
