using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Transeunte: IInfartable
    {
        private Random random = new Random();
        private double probabilidadConsciente, probabilidadRespirar, probabilidadRitmoCardiaco;
        // Métodos
        public bool estasConsciente()
        {
            if (random.NextDouble() < probabilidadConsciente)
                return false;
            return true;
        }

        public bool estasRespirando()
        {
            if (random.NextDouble() < probabilidadRespirar)
                return false;
            return true;
        }

        public bool tenesRitmoCardiaco()
        {
            if (random.NextDouble() < probabilidadRitmoCardiaco)
                return false;
            return true;
        }
        // Constructor
        public Transeunte(double probabilidadConsciente, double probabilidadRespirar, double probabilidadRitmoCardiaco)
        {
            this.probabilidadConsciente = probabilidadConsciente;
            this.probabilidadRespirar = probabilidadRespirar;
            this.probabilidadRitmoCardiaco = probabilidadRitmoCardiaco;
        }
    }
}
