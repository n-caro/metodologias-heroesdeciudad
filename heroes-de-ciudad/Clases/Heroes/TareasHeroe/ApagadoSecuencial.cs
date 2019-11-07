using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoSecuencial : ApagadoSectores, IEstrategiaDeApagado
    {

        override public void apagarIncendio(ILugar lugar, Calle calle)
        { 
            // Obtengo las dimensiones de lugar
            ISector[,] matrizLugar = lugar.getSectores();
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
            // Creo mensajes de finalización en consola
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ResetColor();
        }
    }
}
