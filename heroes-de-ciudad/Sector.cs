using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Sector
    {
        private double porcentajeIncendio;

        // getters-setter
        public double PorcentajeIncendio
        {
            get { return porcentajeIncendio; }
        }

        // Métodos 
        public void mojar(double agua)
        {
            if(agua >= porcentajeIncendio)
            {
                porcentajeIncendio = 0;
            }
            else
            {
                porcentajeIncendio -= agua;
            }
        }

        public bool estaApagado()
        {
            if(porcentajeIncendio == 0)
                return true;
            return false;

        }

        // Constructores
        // para crear Matriz de Casa
        public Sector(double porcentajeIncendioAzar)
        {
            this.porcentajeIncendio = porcentajeIncendioAzar;
        }
    }
}
