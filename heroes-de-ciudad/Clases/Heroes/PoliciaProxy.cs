using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class PoliciaProxy : Responsable, IResponsable
    {
        IFabricaDeHeroes fabrica = new FabricaPolicia();
        IResponsable heroeReal = null;

        public override void patrullarCalles(IPatrullable lugarAPatrullar)
        {
            if (heroeReal == null)
            {
                heroeReal = fabrica.crearHeroe(); // casteo para poder setear orden (propia de un bombero)
                heroeReal.setHerramienta(fabrica.crearHerramienta());
                heroeReal.setVehiculo(fabrica.crearVehiculo());

                // seteo la estrategia de orden, pero antes creo un aux de tipo propio de heroe para poder setear apagado
                Policia aux = (Policia)heroeReal;
                Console.WriteLine("[POLICIA] Elegir orden de policía (ingresar número):");
                Console.WriteLine("     1. Voz de Alto");
                Console.WriteLine("     2. Perseguir y arrestar");
                Console.WriteLine("     3. Avisar y pedir refuerzos");
                bool opcionvalida = false;
                while (!opcionvalida)
                {
                    char op = Console.ReadKey().KeyChar;
                    switch (op)
                    {
                        case '1':
                            aux.setOrdenPolicia(new OPVozDeAlto());
                            opcionvalida = true;
                            break;
                        case '2':
                            aux.setOrdenPolicia(new OPPerseguirYArrestar());
                            opcionvalida = true;
                            break;
                        case '3':
                            aux.setOrdenPolicia(new OPAvisarYPedirRefuerzos());
                            opcionvalida = true;
                            break;
                        default:
                            Console.WriteLine(" \n ERROR: Por favor, ingrese una opción correcta: ");
                            break;
                    }
                }
            }
            heroeReal.patrullarCalles(lugarAPatrullar);
            // devuelvo el bombero creado al cuartel
            fabrica.crearCuartel().agregarPersonal(heroeReal);
            fabrica.crearCuartel().agregarVehiculo(heroeReal.getVehiculo());
            fabrica.crearCuartel().agregarHerramienta(heroeReal.getHerramienta());
        }

    }
}
