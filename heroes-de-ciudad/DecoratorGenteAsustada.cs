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
            //Random r = new Random();
            //int cantidadPersonas = r.Next(0, 5);
            double caudalAModificar = agua;
            for (int i = 0; i < genteAsustada; i++)
            {
                caudalAModificar *= 0.25;
            }
            base.mojar(caudalAModificar);
        }
        // constructor
        public DecoratorGenteAsustada(ISector componente) : base(componente)
        {
            Random r = new Random();
            this.genteAsustada = r.Next(0,5);
        }
    }
}
