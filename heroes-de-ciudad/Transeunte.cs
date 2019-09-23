using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Transeunte: IInfartable
    {
        Random random = new Random();
        double probabilidad = 0.9;
        // Métodos
        public bool estasConsciente()
        {
            if (random.NextDouble() < probabilidad)
                return false;
            return true;
        }

        public bool estasRespirando()
        {
            if (random.NextDouble() < probabilidad)
                return false;
            return true;
        }

        public bool tenesRitmoCardiaco()
        {
            if (random.NextDouble() < probabilidad)
                return false;
            return true;
        }
    }
}
