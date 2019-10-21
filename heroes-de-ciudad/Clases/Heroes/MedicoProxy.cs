using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class MedicoProxy: Responsable, IResponsable
    {
        IFabricaDeHeroes fabrica = new FabricaMedico();
        IResponsable heroeReal = null;

        override public void atenderInfarto(IInfartable paciente)
        {
            if (heroeReal == null)
            {
                heroeReal = fabrica.crearHeroe(); // casteo para poder setear estrategia (propia de un bombero)
                heroeReal.setHerramienta(fabrica.crearHerramienta());
                heroeReal.setVehiculo(fabrica.crearVehiculo());

                // seteo la estrategia de apagado, pero antes creo un aux de tipo Bombero para poder setear apagado
                Medico aux = (Medico)heroeReal;
                Console.WriteLine("[MEDICO] Elegir estrategia de protocolo RCP (ingresar número):");
                Console.WriteLine("     1. Intentar sin detenerse");
                Console.WriteLine("     2. Intentar y desistir");
                bool opcionvalida = false;
                while (!opcionvalida)
                {
                    char op = Console.ReadKey().KeyChar;
                    switch (op)
                    {
                        case '1':
                            aux.setProtocoloRCP(new RCPTipoA());
                            opcionvalida = true;
                            break;
                        case '2':
                            aux.setProtocoloRCP(new RCPTipoB());
                            opcionvalida = true;
                            break;
                        default:
                            Console.WriteLine(" \n ERROR: Por favor, ingrese una opción correcta: ");
                            break;
                    }
                }
            }
            heroeReal.atenderInfarto(paciente);
            // devuelvo el bombero creado al cuartel
            fabrica.crearCuartel().agregarPersonal(heroeReal);
            fabrica.crearCuartel().agregarVehiculo(heroeReal.getVehiculo());
            fabrica.crearCuartel().agregarHerramienta(heroeReal.getHerramienta());
        }

        // Chain of Responsability
        public MedicoProxy(IResponsable r) : base(r)
        {

        }
        public MedicoProxy() : base(null)
        {

        }
        // end Chain of responsability
    }
}
