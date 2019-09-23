using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Plaza : ILugar, IPatrullable
    {
        private string nombre;
        private int superficie;
        private int arboles;
        private int farolas;
        private Calle calle;
        // Alarma con Patrón Observer
        private List<IAlarmaIncendioObserver> observadoresAlarma = new List<IAlarmaIncendioObserver>();

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
        public Calle getCalle()
        {
            return calle;
        }

        // Métodos 
        public Sector[,] getSectores()
        {
            double raizRedondeadaSuperficie = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizRedondeadaSuperficie);
            Sector[,] matrizAfectada = new Sector[dimension, dimension];
            Random r = new Random();
            for (int fila = 0; fila < dimension; fila++)
            {
                for (int columna = 0; columna < dimension; columna++)
                {
                    double porcentajeRandom = r.Next(101);
                    matrizAfectada[fila, columna] = new Sector(porcentajeRandom);
                    Console.WriteLine("Creado: ({0},{1}) - Sector porcentaje: {2}", fila, columna, matrizAfectada[fila, columna].PorcentajeIncendio);
                }
            }
            return matrizAfectada;
        }


        // Provocar incendios - Alarma con Patron Observer
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
            foreach (IAlarmaIncendioObserver o in observadoresAlarma)
            {
                o.actualizar(this);
            }
        }

        public bool hayAlgoFueraDeLoNormal()
        {
            double probabilidad = 0.3;
            Random random = new Random();
            if (random.NextDouble() > probabilidad)
                return true;
            return false;
        }

        // Constructores
        public Plaza(string nombre, int superficie, int arboles, int farolas, Calle calle)
        {
            this.nombre = nombre;
            this.superficie = superficie;
            this.arboles = arboles;
            this.farolas = farolas;
            this.calle = calle;
        }
    }
}