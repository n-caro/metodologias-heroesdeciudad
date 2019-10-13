using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciaDeIncendio: IDenuncia
    {
        ILugar lugar;

        public void atender(IResponsable bombero) {
            bombero.apagarIncendio(lugar);
        }

        //setters-getters
        public ILugar getLugar()
        {
            return lugar;
        }
        // Constructor

        public DenunciaDeIncendio(ILugar lugar)
        {
            this.lugar = lugar;
        }
    }
}
