﻿using System;
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
            double resultado = Math.Exp(velocidadViento / 100);
            base.mojar(agua - resultado);
        }
        // constructor
        public DecoratorMuchoViento(ISector componente) : base(componente)
        {
            Random r = new Random();
            this.velocidadViento = r.Next(80,250);
        }
    }
}
