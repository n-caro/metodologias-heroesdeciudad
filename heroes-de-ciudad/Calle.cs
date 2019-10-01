using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Calle: IIluminable
    {
        private int longitud;
        private int farolas;
        private int caudalAgua;

        public Calle(int longitud, int farolas, int caudalAgua)
        {
            this.longitud = longitud;
            this.farolas = farolas;
            this.caudalAgua = caudalAgua;
        }

        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public int Farolas
        {
            get { return farolas; }
            set { farolas = value; }
        }
        public int CaudalAgua
        {
            get { return caudalAgua; }
            set { caudalAgua = value; }
        }
        // Métodos
        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las lámparas quemadas de la calle.");
        }
    }
}
