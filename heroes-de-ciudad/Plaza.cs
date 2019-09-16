using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Plaza : ILugar
    {
        private string nombre;
        private int superficie;
        private int arboles;
        private int farolas;
        private Calle calle;

        // getters-setters
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
        public Calle Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        // Métodos 
        public int[,] getSectores()
        {
            double raizSuperficieRedondeada = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizSuperficieRedondeada);
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
        public Plaza(string nombre, int superficie, int arboles, int farolas)
        {
            this.nombre = nombre;
            this.superficie = superficie;
            this.arboles = arboles;
            this.farolas = farolas;
        }
    }
}