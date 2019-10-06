using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class IteradorDenunciasDeMostrador : IteradorDeDenucias
    {
        private DenunciasPorMostrador denunciaMostrador;
        bool estaProcesada = false;
        public IDenuncia actual()
        {
            return denunciaMostrador.getDenuncia();
        }

        public bool fin()
        {
            return estaProcesada;
        }

        public void siguiente()
        {
            estaProcesada = true;
        }

        // Constructor 
        public IteradorDenunciasDeMostrador(DenunciasPorMostrador denunciaMostrador)
        {
            this.denunciaMostrador = denunciaMostrador;
        }
    }
}
