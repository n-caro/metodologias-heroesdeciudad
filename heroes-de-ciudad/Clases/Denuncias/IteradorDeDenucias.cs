﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface IteradorDeDenucias
    {
        IDenuncia actual();
        void siguiente();

        bool fin();
    }
}
