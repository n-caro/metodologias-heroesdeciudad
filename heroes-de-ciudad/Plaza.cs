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
            ISector[,] matrizAfectada = new ISector[dimension, dimension];
            // Establezco variables en común, para decorar
            int caudalLluvia = random.Next(0, 15);
            int temperatura = random.Next(-5, 45);
            int velocidadViento = random.Next(0, 250);
            Console.WriteLine("     < Estado del día: {0} caudal de lluvia - {1}° temperatura - {2} velocidad de viento >", caudalLluvia, temperatura, velocidadViento);
            //
            for (int fila = 0; fila < dimension; fila++)
            {
                for (int columna = 0; columna < dimension; columna++)
                {
                    matrizAfectada[fila, columna] = crearSector(caudalLluvia, temperatura, velocidadViento);
                    //Console.WriteLine("Creado: ({0},{1}) - Sector porcentaje: {2}", fila, columna, matrizAfectada[fila, columna].getPorcentajeIncendio());
                }
            }
            return matrizAfectada;
        }

        // Creador de Sectores
        private ISector crearSector(int caudalLluvia, int temperatura, int velocidadViento)
        {
            //Random random = new Random();
            int porcentajeRandom = random.Next(100);
            Sector sector = new Sector(porcentajeRandom);
            return decorarSector(sector, caudalLluvia, temperatura, velocidadViento);
        }

        private ISector decorarSector(ISector sector, int caudalLluvia, int temperatura, int velocidadViento)
        {
            //Random random = new Random();
            double probabilidad_de_decorar = 0.2;
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.PastoSeco);
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.ArbolesGrandes);
            if (random.NextDouble() < probabilidad_de_decorar)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.GenteAsustada);
            if (temperatura > 30)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.MuchoCalor);
            if (velocidadViento > 80)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.MuchoViento);
            if (caudalLluvia > 0)
                sector = FabricaDeDecoradosSector.decorarSector(sector, FabricaDeDecoradosSector.DiaLLuvioso);
            return sector;
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