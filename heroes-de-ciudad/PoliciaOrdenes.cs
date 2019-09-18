using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class OPPerseguirYArrestar : IOrdenPolicia
    {
        public void Ejecutar()
        {
            Console.WriteLine("   POLICIA: - ¡¡Persiguiendo hasta arrestar al delincuente!!");
        }
    }

    class OPVozDeAlto : IOrdenPolicia
    {
        public void Ejecutar()
        {
            Console.WriteLine("   POLICIA: - ¡¡Alto!!");
        }
    }

    class OPAvisarYPedirRefuerzos : IOrdenPolicia
    {
        public void Ejecutar()
        {
            Console.WriteLine("   POLICIA: - ¡¡Avisando a la comisaría y pidiendo refuerzos!!");
        }
    }

}
