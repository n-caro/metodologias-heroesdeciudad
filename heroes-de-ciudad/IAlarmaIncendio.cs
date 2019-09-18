using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    interface IAlarmaIncendio
    {
        void agregarObservador(IAlarmaIncendioObserver o);
        void notificar();

        //agregado para que un bombero pueda obtener calle de cualquier ILugar
        Calle getCalle();
    }
}
