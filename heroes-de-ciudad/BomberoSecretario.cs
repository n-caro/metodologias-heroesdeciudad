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
            int contador = 0;
            while (iterador.fin() != true)
            {
                Console.WriteLine("Atendiendo denuncia numero: " + contador);
                IDenuncia denuncia = iterador.actual();
                ILugar denunciaLugar = denuncia.getLugar();
                bombero.apagarIncendio(denunciaLugar);
                iterador.siguiente();
                contador++;
            }
        }
    }
}
