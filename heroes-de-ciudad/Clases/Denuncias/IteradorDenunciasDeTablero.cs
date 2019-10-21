using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class IteradorDenunciasDeTablero : IteradorDeDenucias
    {
        int paginaActual;
        List<IDenuncia> listaDenuncias;
        public void primero()
        {
            paginaActual = 0;
        }
        public void siguiente()
        {
            paginaActual = paginaActual + 1;
        }
        public bool fin()
        {
            return paginaActual >= listaDenuncias.Count;
        }
        public IDenuncia actual()
        {
            return listaDenuncias[paginaActual];
        }

        // Constructor
        public IteradorDenunciasDeTablero(DenunciasPorTablero denunciasPorTablero)
        {
            this.listaDenuncias = denunciasPorTablero.getListaDenuncias();
            paginaActual = 0;
        }
    }
}
