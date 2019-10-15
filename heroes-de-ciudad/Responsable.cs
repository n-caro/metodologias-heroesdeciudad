using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class Responsable
    {
        // Chain of Responsability
        IResponsable sucesor;
        virtual public void apagarIncendio(ILugar lugar)
        {
            if (sucesor != null)
                sucesor.apagarIncendio(lugar);
        }

        virtual public void atenderInfarto(IInfartable paciente)
        {
            if (sucesor != null)
                sucesor.atenderInfarto(paciente);
        }

        virtual public void patrullarCalles(IPatrullable lugarAPatrullar)
        {
            if (sucesor != null)
                sucesor.patrullarCalles(lugarAPatrullar);
        }

        virtual public void revisar(IIluminable iluminable)
        {
            if (sucesor != null)
                sucesor.revisar(iluminable);
        }

        // setter-getter generales de herramientas y vehículos
        // Constructor
        public Responsable(IResponsable r)
        {
            sucesor = r;
        }
    }
}
