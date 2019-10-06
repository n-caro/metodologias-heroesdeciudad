using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciasPorWhatsapp: IDenuncias
    {
        MensajeWhatsapp lista;

        // Constructor
        public DenunciasPorWhatsapp(MensajeWhatsapp lista)
        {
            this.lista = lista;
        }
        // Métodos
        public IteradorDeDenucias crearIterador()
        {
            return new IteradorDenunciasDeWhatsapp(this.lista);
        }
    }
}
