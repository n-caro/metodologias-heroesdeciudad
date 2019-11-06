using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorMuchoViento: DecoratorSector
    {
        private int velocidadViento;
        public override void mojar(double agua)
        {
            //int velocidadViento = random.Next(80, 250);
            double resultado = Math.Exp(velocidadViento / 100);
            base.mojar(agua - resultado);
        }
        // constructor
        public DecoratorMuchoViento(ISector componente) : base(componente)
        {
            this.velocidadViento = random.Next(80,250);
        }
    }
}
