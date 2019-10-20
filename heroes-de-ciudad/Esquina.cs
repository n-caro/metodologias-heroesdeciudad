using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Esquina: IPatrullable, IIluminable
    {
        private int semaforos;
        Random random = new Random();
        // getters - setters
        public Esquina(int semaforo)
        {
            this.semaforos = semaforo;
        }
        public int Semaforos
        {
            get { return semaforos; }
            set { semaforos = value; }
        }

        // Métodos
        public bool hayAlgoFueraDeLoNormal()
        {
            double probabilidad = 0.5;
            if (random.NextDouble() > probabilidad)
                return true;
            return false;
        }

        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las lámparas quemadas de la esquina.");
        }

    }
}
