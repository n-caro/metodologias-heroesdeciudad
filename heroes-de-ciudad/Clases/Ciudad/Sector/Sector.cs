using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Sector: ISector
    {
        private double porcentajeIncendio;


        // Métodos 
        public void mojar(double agua)
        {
            agua = Math.Round(agua, 2);
            if (agua >= porcentajeIncendio)
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

        public double getPorcentajeIncendio()
        {
            return Math.Round(porcentajeIncendio, 2);
        }

        // Constructores
        // para crear Matriz de Casa
        public Sector(double porcentajeIncendioAzar)
        {
            this.porcentajeIncendio = porcentajeIncendioAzar;
        }
    }
}
