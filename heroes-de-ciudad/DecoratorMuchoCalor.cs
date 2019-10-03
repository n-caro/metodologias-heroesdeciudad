﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DecoratorMuchoCalor: DecoratorSector
    {
        private int temperatura;
        public override void mojar(double agua)
        {
            // parámetro temperatura (entre 30 y 45) y le resta al valor de agua recibido el resultado de(0.1 * temperatura)
            base.mojar(agua - (0.1 * temperatura));
        }
        // constructor
        public DecoratorMuchoCalor(ISector componente) : base(componente)
        {
            Random r = new Random();
            this.temperatura = r.Next(30,45);
        }
    }
}
