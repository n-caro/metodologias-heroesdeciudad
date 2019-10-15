﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Casa : ILugar, IPatrullable
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

        // Matriz de ISectores
        public ISector[,] getSectores()
        {
            double raizRedondeadaSuperficie = Math.Round(Math.Sqrt(superficie));
            int dimension = Convert.ToInt32(raizRedondeadaSuperficie);
            ISector[,] matrizAfectada = new Sector[dimension, dimension];
            Random r = new Random();
            for (int fila = 0; fila < dimension; fila++)
            {
                for (int columna = 0; columna < dimension; columna++)
                {
                    double porcentajeRandom = r.Next(101);
                    matrizAfectada[fila, columna] = new Sector(porcentajeRandom);
                    //Console.WriteLine("Creado: ({0},{1}) - Sector porcentaje: {2}", fila, columna, matrizAfectada[fila, columna].getPorcentajeIncendio());
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

        public bool hayAlgoFueraDeLoNormal()
        {
            double probabilidad = 0.8;
            Random random = new Random();
            if (random.NextDouble() > probabilidad)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Casa (puerta n° " + puerta + ")";
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
