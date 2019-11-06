using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorArbolesGrandes: DecoratorSector
    {
        public override void mojar(double agua)
        {
            // arboles resta un 25% al valor del caudal de agua (es decir el 75% del caudal)
            base.mojar(agua * 0.75);
        }
        // constructor
        public DecoratorArbolesGrandes(ISector componente) : base(componente)
        {

        }
    }
}
