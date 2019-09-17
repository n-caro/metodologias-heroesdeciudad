using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoSecuencial : IEstrategiaDeApagado
    {
        public void RecorrerLugar(ILugar lugar, Calle calle)
        {
            // Obtengo las dimensiones de lugar
            int[,] matrizLugar = lugar.getSectores();
            int caudalAgua = calle.CaudalAgua;

            int lugarFilas = matrizLugar.GetLength(0);
            int lugarColumnas = matrizLugar.GetLength(1);

            for (int fila = 0; fila < lugarFilas; fila++)
            {
                for (int columna = 0; columna < lugarColumnas; columna++)
                {
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
