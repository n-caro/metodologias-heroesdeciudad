using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DirectorDeSectores
    {
        private ConstructorEscenarioIncendio constructor;

        private Random random = new Random();

        // Constructor
        public DirectorDeSectores(ConstructorEscenarioIncendio c)
        {
            constructor = c;
        }

        public ISector[,] construirMatriz(int filas, int columnas)
        {
            ISector[,] matrizIncendio = new ISector[filas, columnas];
            // creo valores al azar de clima para decorar el sector
            int caudalLluvia = random.Next(0, 15);
            int temperatura = random.Next(-5, 45);
            int velocidadViento = random.Next(0, 250);
            // itero cada sector de la matriz para asignar sector
            for (int fil = 0; fil < filas; fil++)
            {
                for (int col = 0; col < columnas; col++)
                {
                    constructor.crearSector();
                    constructor.decorarSector(caudalLluvia, temperatura, velocidadViento);
                    matrizIncendio[fil, col] = constructor.obtenerSector();
                }
            }

            return matrizIncendio;
        }

    }
}
