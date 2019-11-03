using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class Responsable: IResponsable
    {
        IResponsable sucesor = null;
        protected IHerramienta herramienta;
        protected IVehiculo vehiculo;

        // setters-getter
        public IHerramienta getHerramienta()
        {
            return herramienta;
        }
        public void setHerramienta(IHerramienta herramienta) { this.herramienta = herramienta; }
        public IVehiculo getVehiculo() { return vehiculo; }
        public void setVehiculo(IVehiculo vehiculo) { this.vehiculo = vehiculo; }
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

        public void setSiguiente(IResponsable sucesor)
        {
            this.sucesor = sucesor;
        }
        // setter-getter generales de herramientas y vehículos
    }
}
