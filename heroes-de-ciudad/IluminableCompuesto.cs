using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class IluminableCompuesto: IIluminable
    {
        private string nombreCompuesto;
        private List<IIluminable> hijos = new List<IIluminable>();
        // método
        public void revisarYCambiarLamparasQuemadas()
        {
            Console.WriteLine("Revisando y cambiando lámparas quemadas de " + nombreCompuesto);
            foreach(IIluminable i in hijos)
            {
                i.revisarYCambiarLamparasQuemadas();
            }
        }
        public void agregarHijo(IIluminable iluminable)
        {
            hijos.Add(iluminable);
        }
        // constructor
        public IluminableCompuesto(string nombreCompuesto)
        {
            this.nombreCompuesto = nombreCompuesto;
        }
    }


}
