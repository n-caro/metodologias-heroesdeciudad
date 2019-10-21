using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class BomberoSecretario
    {
        private Bombero bombero;
        // Constructor
        public BomberoSecretario(Bombero bombero)
        {
            this.bombero = bombero;
        }
        // Método
        public void atenderDenuncias(IDenuncias denuncias)
        {
            IteradorDeDenucias iterador = denuncias.crearIterador();
            while (iterador.fin() != true)
            {
                IDenuncia denuncia = iterador.actual();
                denuncia.atender(bombero);
                iterador.siguiente();
            }
        }
    }
}
