using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Esquina
    {
        private int semaforos;

        public Esquina(int semaforo)
        {
            this.semaforos = semaforo;
        }
        public int Semaforos
        {
            get { return semaforos; }
            set { semaforos = value; }
        }
    }
}
