using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorGenteAsustada: DecoratorSector
    {
        private int genteAsustada;
        public override void mojar(double agua)
        {
            double caudalAModificar = agua;
            //int genteAsustada = random.Next(0, 5);
            for (int i = 0; i < genteAsustada; i++)
            {
                caudalAModificar *= 0.25;
            }
            base.mojar(caudalAModificar);
        }
        // constructor
        public DecoratorGenteAsustada(ISector componente) : base(componente)
        {
            this.genteAsustada = random.Next(0, 5);
        }
    }
}
