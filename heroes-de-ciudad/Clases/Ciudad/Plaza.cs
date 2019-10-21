using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Plaza : ILugar, IPatrullable, IIluminable
    {
        private string nombre;
        private int superficie;
        private int arboles;
        private int farolas;
        private Calle calle;
        private Random random = new Random();
        // Alarma con Patrón Observer
        private List<IAlarmaIncendioObserver> observadoresAlarma = new List<IAlarmaIncendioObserver>();
        // 10 - Builder
        private DirectorDeSectores directorDeSectores;


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
        public ISector[,] getSectores()
        {
            double raizRedondeadaSuperficie = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizRedondeadaSuperficie);
            return directorDeSectores.construirMatriz(dimension, dimension);
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
            if(observadoresAlarma.Count > 0)
            {
                foreach (IAlarmaIncendioObserver o in observadoresAlarma)
                {
                    o.actualizar(this);
                }
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

        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las lámparas quemadas de la plaza.");
        }

        // Constructores
        public Plaza(string nombre, int superficie, int arboles, int farolas, Calle calle, DirectorDeSectores directorDeSectores)
        {
            this.nombre = nombre;
            this.superficie = superficie;
            this.arboles = arboles;
            this.farolas = farolas;
            this.calle = calle;
            this.directorDeSectores = directorDeSectores;
        }
    }
}