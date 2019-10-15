using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class BomberoProxy: Responsable, IResponsable
    {
        FabricaBombero fabrica = new FabricaBombero();
        IResponsable heroeReal = null;

        override public void apagarIncendio(ILugar lugar)
        {
            if (heroeReal == null)
            {
                heroeReal = (Bombero)fabrica.crearHeroe(); // casteo para poder setear estrategia (propia de un bombero)
                heroeReal.setHerramienta(fabrica.crearHerramienta());
                heroeReal.setVehiculo(fabrica.crearVehiculo());

                // seteo la estrategia de apagado, pero antes creo un aux de tipo Bombero para poder setear apagado
                Bombero aux = (Bombero)heroeReal;
                Console.WriteLine("[BOMBERO] Elegir estrategia de apagado (ingresar número):");
                Console.WriteLine("     1. Apagado Secuencial");
                Console.WriteLine("     2. Apagado Escalera");
                Console.WriteLine("     3. Apagado Espiral");
                bool opcionvalida = false;
                while (!opcionvalida)
                {
                    char op = Console.ReadKey().KeyChar;
                    switch (op)
                    {
                        case '1':
                            aux.setEstrategiaApagado(new ApagadoSecuencial());
                            opcionvalida = true;
                            break;
                        case '2':
                            aux.setEstrategiaApagado(new ApagadoEscalera());
                            opcionvalida = true;
                            break;
                        case '3':
                            aux.setEstrategiaApagado(new ApagadoEspiral());
                            opcionvalida = true;
                            break;
                        default:
                            Console.WriteLine(" \n ERROR: Por favor, ingrese una opción correcta: ");
                            break;
                    }
                }
            }
            heroeReal.apagarIncendio(lugar);
            // devuelvo el bombero creado al cuartel
            fabrica.crearCuartel().agregarPersonal(heroeReal);
            /* En caso de que hay que guardar la herramienta y vehículo
            fBomberos.crearCuartel().agregarVehiculo(bomberoReal.getVehiculo());
            fBomberos.crearCuartel().agregarHerramienta(bomberoReal.getHerramienta());
            */
        }
        // IMPLEMENTACIONES DE IRESPONSABLE
        public IHerramienta getHerramienta()
        {
            throw new NotImplementedException();
        }

        public IVehiculo getVehiculo()
        {
            throw new NotImplementedException();
        }

        public void setHerramienta(IHerramienta h)
        {
            throw new NotImplementedException();
        }

        public void setVehiculo(IVehiculo v)
        {
            throw new NotImplementedException();
        }


        // Chain of Responsability
        public BomberoProxy(IResponsable r) : base(r)
        {

        }
        public BomberoProxy() : base(null)
        {

        }
        // end Chain of responsability
    }
}
