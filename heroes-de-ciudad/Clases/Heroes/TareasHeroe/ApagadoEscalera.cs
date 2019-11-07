using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class ApagadoEscalera : ApagadoSectores, IEstrategiaDeApagado
    {

        override public void apagarIncendio(ILugar lugar, Calle calle)
        {
            ISector[,] matrizLugar = lugar.getSectores();
            int caudalAgua = calle.CaudalAgua;

            int lugarCantFilas = matrizLugar.GetLength(0);
            int lugarCantColumnas = matrizLugar.GetLength(1);

            for (int fila = 0; fila < lugarCantFilas; fila++)
            {
                if ((fila%2) == 0)
                {
                    //Console.WriteLine("La fila es par, recorrido --> ");
                    for(int columna = 0; columna < lugarCantColumnas; columna++ )
                    {
                        ApagarSector(fila, columna, matrizLugar, caudalAgua);

                    }
                }
                else
                {
                    //Console.WriteLine("La fila es impar, recorrido <-- ");
                    for (int columna = lugarCantColumnas-1; columna >= 0; columna--)
                    {
                        ApagarSector(fila, columna, matrizLugar, caudalAgua);
                    }
                }
            }
            // Creo mensajes de finalización en consola
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      ¡¡¡¡¡¡¡ El fuego de {0} fue extinguido en su totalidad!!!!!! \n", lugar);
            Console.ResetColor();
        }
        

    }

}
