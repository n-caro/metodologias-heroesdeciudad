using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciasPorMostrador : IDenuncias
    {
        private IDenuncia denuncia;

        //getter
        public IDenuncia getDenuncia()
        {
            return denuncia;
        }


        public DenunciasPorMostrador(IDenuncia denuncias)
        {
            this.denuncia = denuncias;
        }

        // Métodos

        public IteradorDeDenucias crearIterador()
        {
            return new IteradorDenunciasDeMostrador(this);
        }
    }
}
