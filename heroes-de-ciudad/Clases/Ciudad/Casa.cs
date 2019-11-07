using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Casa : Lugar, ILugar, IPatrullable
    {
        private int puerta;
        private int habitantes;

        // getters-setters
        public int Puerta
        {
            get { return puerta; }
            set { puerta = value; }
        }
        public int Habitantes
        {
            get { return habitantes; }
            set { habitantes = value; }
        }

        // Métodos

        public override string ToString()
        {
            return "Casa (puerta n° " + puerta + ")";
        }
        // 03 - Observer

        public void chispa()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡¡¡¡Se ha activado la alarma de incendios de " + this + "!!!!");
            Console.ResetColor();
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
        // -----------end: 03 - Observer ------------------------ //

        // Constructores
        public Casa(int puerta, int superficie, int habitantes, Calle calle, DirectorDeSectores directorDeSectores)
        {
            this.puerta = puerta;
            this.superficie = superficie;
            this.habitantes = habitantes;
            this.calle = calle;
            this.directorDeSectores = directorDeSectores;
        }

    }
}
