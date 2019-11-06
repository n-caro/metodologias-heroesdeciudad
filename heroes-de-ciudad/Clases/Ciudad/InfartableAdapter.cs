using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    /// <summary>
    /// Se aplica el patrón Adapter
    /// </summary>
    class InfartableAdapter : IInfartable
    {
        private Passerby passerby; 

        public bool estasConsciente()
        {
            return passerby.isConscious();
        }

        public bool estasRespirando()
        {
            return passerby.isBreathing();
        }

        public bool tenesRitmoCardiaco()
        {
            return passerby.haveHeartRate();
        }

        // Constructor
        public InfartableAdapter(Passerby p)
        {
            this.passerby = p;
        }
    }
}
