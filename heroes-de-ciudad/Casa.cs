using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Casa: ILugar
    {
        private int puerta;
        private int superficie;
        private int habitantes;

        // getters-setters
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

        // Métodos
        public int[,] getSectores()
        {
            double raizRedondeadaSuperficie = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizRedondeadaSuperficie);
            int[,] matrizAfectada = new int[dimension, dimension];
            Random r = new Random();
            for (int fila = 0; fila < dimension; fila++)
            {
                for (int columna = 0; columna < dimension; columna++)
                {
                    matrizAfectada[fila, columna] = r.Next(101);
                }
            }
            return matrizAfectada; 
        }

        // Constructores
        public Casa(int puerta, int superficie, int habitantes)
        {
            this.puerta = puerta;
            this.superficie = superficie;
            this.habitantes = habitantes;
        }

    }
}
