using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    // Es Nodo de Lista Enlazada
    class MensajeWhatsapp
    {
        IDenuncia denuncia;
        MensajeWhatsapp siguiente;

         
        // getter
        public IDenuncia getDenuncia()
        {
            return denuncia;
        }
        public MensajeWhatsapp getSiguiente()
        {
            return siguiente;
        }

        // Constructor
        public MensajeWhatsapp(IDenuncia denuncia, MensajeWhatsapp siguiente)
        {
            this.denuncia = denuncia;
            this.siguiente = siguiente;
        }
    }
}
