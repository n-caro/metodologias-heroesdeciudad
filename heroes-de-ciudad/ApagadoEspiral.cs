using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoEspiral : EstrategiaDeApagado
    {
        public void RecorrerLugar(ILugar lugar, Calle calle)
        {
            int[,] matrizLugar = lugar.getSectores();
            int caudalAgua = calle.CaudalAgua;

            int CantFilas = matrizLugar.GetLength(0);
            int CantColumnas = matrizLugar.GetLength(1);
            int aux = CantColumnas - 1;
            int fila, columna;
            for (int i = 0; i < CantFilas; i++)
            {
                // a derecha
                for(int j = i; j < aux; j++)
                {
                    fila = CantFilas - (aux + 1);
                    columna = j;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // a abajo
                for (int j = i; j < aux; j++)
                {
                    fila = j;
                    columna = aux;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // a izquierda
                for (int j = aux; j > (i - 1); j--)
                {
                    fila = aux;
                    columna = j;
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }

                // increento aux
                aux--;

                // hacia arriba
                for (int j = aux; j > i; j--)
                {
                    fila = j;
                    columna = CantFilas - (aux + 2);
                    ApagarSector(fila, columna, matrizLugar, caudalAgua);
                }
            }


        }

        private void ApagarSector(int fila, int columna, int[,] matrizLugar, int caudalAgua)
        {
            int porcentajeIncendio = matrizLugar[fila, columna];
            StringBuilder estado_Incendio = new StringBuilder();
            if (porcentajeIncendio > caudalAgua)
            {
                int porcentajeIncendioRestante = porcentajeIncendio - caudalAgua;
                estado_Incendio.Append("-> ");
                estado_Incendio.Append(porcentajeIncendioRestante);
                while (porcentajeIncendioRestante > caudalAgua)
                {
                    porcentajeIncendioRestante -= caudalAgua;
                    estado_Incendio.Append("-> ");
                    estado_Incendio.Append(porcentajeIncendioRestante);
                }
            }
            Console.WriteLine("     ({0},{1}) -> {2} {3}-> 0", fila, columna, porcentajeIncendio, estado_Incendio);
        }

    }
}
