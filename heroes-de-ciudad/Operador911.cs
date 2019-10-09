using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Operador911
    {
        IResponsable responsable;

        void atenderDenuncias(IDenuncias denuncias)
        {
            Console.WriteLine("Operador 911 está atendiendo las denuncias");
            // Método 
            IteradorDeDenucias iterador = denuncias.crearIterador();
            while (iterador.fin() != true)
            {
                IDenuncia denuncia = iterador.actual();
                denuncia.atender(responsable);
                iterador.siguiente();
            }
        }

        // Constructor
        public Operador911(IResponsable responsable)
        {
            this.responsable = responsable;
        }
    }
}
