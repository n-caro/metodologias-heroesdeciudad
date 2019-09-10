using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Plaza
    {
        private string nombre;
        private int superficie;
        private int arboles;
        private int farolas;

        public Plaza(string nombre, int superficie, int arboles, int farolas)
        {
            this.nombre = nombre;
            this.superficie = superficie;
            this.arboles = arboles;
            this.farolas = farolas;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Superficie
        {
            get { return superficie; }
            set { superficie = value; }
        }
        public int Arboles
        {
            get { return arboles; }
            set { arboles = value; }
        }
        public int Farolas
        {
            get { return farolas; }
            set { farolas = value; }
        }
    }
}
