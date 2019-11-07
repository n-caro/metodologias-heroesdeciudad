using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class Lugar
    {
        protected int superficie;
        protected Calle calle;
        // 03 - Observer
        protected List<IAlarmaIncendioObserver> observadoresAlarma = new List<IAlarmaIncendioObserver>();
        // 10 - Builder
        protected DirectorDeSectores directorDeSectores;
        // Random
        protected Random random = new Random();

        // getter-setters
        public int Superficie
        {
            get { return superficie; }
        }
        public Calle getCalle()
        {
            return calle;
        }

        // Matriz de ISectores
        public ISector[,] getSectores()
        {
            double raizRedondeadaSuperficie = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizRedondeadaSuperficie);
            return directorDeSectores.construirMatriz(dimension, dimension);
        }

        // metodo para que el policia atienda el patrullaje
        public bool hayAlgoFueraDeLoNormal()
        {
            double probabilidad = 0.3;
            Random random = new Random();
            if (random.NextDouble() > probabilidad)
                return true;
            return false;
        }

    }
}
