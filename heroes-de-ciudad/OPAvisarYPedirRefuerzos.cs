using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class OPAvisarYPedirRefuerzos : IOrdenPolicia
    {
        public void Ejecutar()
        {
            Console.WriteLine("   POLICIA: - ¡¡Avisando a la comisaría y pidiendo refuerzos!!");
        }
    }
}
