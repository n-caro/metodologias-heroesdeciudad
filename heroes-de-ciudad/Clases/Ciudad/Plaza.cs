using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Plaza : Lugar, ILugar, IPatrullable, IIluminable
    {
        private string nombre;
        private int arboles;
        private int farolas;


        // getters-setters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        // Métodos 

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

        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Cambiando las lámparas quemadas de " + this);
        }

        public override string ToString()
        {
            return "Calle " + nombre;
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