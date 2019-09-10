using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Casa
    {
        private int puerta;
        private int superficie;
        private int habitantes;

        public Casa(int puerta, int superficie, int habitantes)
        {
            this.puerta = puerta;
            this.superficie = superficie;
            this.habitantes = habitantes;
        }

        public int Puerta
        {
            get { return puerta; }
            set { puerta = value; }
        }
        public int Superficie
        {
            get { return superficie; }
            set { superficie = value; }
        }
        public int Habitantes
        {
            get { return habitantes; }
            set { habitantes = value; }
        }

    }
}
