using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Casa : ILugar
    {
        private int puerta;
        private int superficie;
        private int habitantes;
        private Calle calle;
        private List<IAlarmaIncendioObserver> observadoresAlarma = new List<IAlarmaIncendioObserver>();

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

        public Calle getCalle()
        {
            return calle;
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

        public void chispa()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡¡¡¡Se ha activado la alarma de incendios!!!!!");
            Console.ForegroundColor = ConsoleColor.White;
            this.notificar();
        }

        public void agregarObservador(IAlarmaIncendioObserver o)
        {
            observadoresAlarma.Add(o);
        }

        public void notificar()
        {
            foreach(IAlarmaIncendioObserver o in observadoresAlarma)
            {
                o.actualizar(this);
            }
        }
        // Constructores
        public Casa(int puerta, int superficie, int habitantes, Calle calle)
        {
            this.puerta = puerta;
            this.superficie = superficie;
            this.habitantes = habitantes;
            this.calle = calle;
        }

    }
}
