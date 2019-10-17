using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class HeroesDeCiudad
    {

        static ICuartel crearHeroe(IFabricaDeHeroes fabrica)
        {
            ICuartel cuartel = fabrica.crearCuartel();
            IResponsable heroe = fabrica.crearHeroe();
            cuartel.agregarPersonal(heroe);
            IVehiculo vehiculo = fabrica.crearVehiculo();
            cuartel.agregarVehiculo(vehiculo);
            IHerramienta herramienta = fabrica.crearHerramienta();
            cuartel.agregarHerramienta(herramienta);
            return cuartel;
            
        }
        static void Main(string[] args)
        {
            TestingHeroesDeCiudad.tituloDecorado();
            Console.WriteLine("HEROES DE CIUDAD");
            Console.WriteLine("<testing>");

            // heroes
            // creo Cadena
            IResponsable cadena = new BomberoProxy(null); // proxy
            cadena = new Medico(cadena);
            cadena = new Policia(cadena);
            cadena = new Electricista(cadena);

            Operador911 op = new Operador911(cadena);




            // armar cadena?

            // 10 ILugar
            DirectorDeSectores directorFavorable = new DirectorDeSectores(new ConstructorDesfavorable());

            Calle callePrincipal = new Calle(10, 10, 50); // 50 de agua
            Calle calleSecundaria = new Calle(10, 10, 20); // 20 de agua

            Casa A = new Casa(1, 4, 10, callePrincipal, directorFavorable);
            Casa B = new Casa(1, 16, 10, callePrincipal, directorFavorable);
            Casa C = new Casa(1, 9, 10, calleSecundaria, directorFavorable);
            Casa D = new Casa(1, 9, 10, calleSecundaria, directorFavorable);
            Casa E = new Casa(1, 16, 10, calleSecundaria, directorFavorable);
            Casa F = new Casa(1, 40, 10, calleSecundaria, directorFavorable);
            Plaza G = new Plaza("Plaza Principal", 25, 10, 10, callePrincipal, directorFavorable);
            Casa H = new Casa(1, 4, 10, calleSecundaria, directorFavorable);
            Casa I = new Casa(1, 30, 10, callePrincipal, directorFavorable);
            Casa J = new Casa(1, 25, 10, calleSecundaria, directorFavorable);


            // Instancie una DenunciasPorTablero y hágala observadora de los lugares A, B, C, D, E y F. 
            DenunciasPorTablero denunciasPorTablero = new DenunciasPorTablero();
            A.agregarObservador(denunciasPorTablero);
            B.agregarObservador(denunciasPorTablero);
            C.agregarObservador(denunciasPorTablero);
            D.agregarObservador(denunciasPorTablero);
            E.agregarObservador(denunciasPorTablero);
            F.agregarObservador(denunciasPorTablero);

            //Instancie una DenunciasPorWhatsapp y agréguele los lugares G, H e I
            MensajeWhatsapp mensajeswpp = null;
            // 3 denuncias de incendio
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(G), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(H), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(I), mensajeswpp);
            // agregando denuncias 12 - chain
            // 2 denuncias de infarto
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeInfarto(new Transeunte(0.7, 0.7, 0.7)), mensajeswpp);
            InfartableAdapter passerby = new InfartableAdapter(new Passerby(0.7, 0.7, 0.7));
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeInfarto(passerby), mensajeswpp);
            // 3 denuncias de robo
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeRobo(A), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeRobo(C), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeRobo(D), mensajeswpp);
            // 5 denuncias lamparas quemadas
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(G), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Esquina(10)), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(new Esquina(2)), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(calleSecundaria), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeLamparaQuemada(callePrincipal), mensajeswpp);
            DenunciasPorWhatsapp denunciasPorWhatsapp = new DenunciasPorWhatsapp(mensajeswpp);

            // Instancie una DenunciasPorMostrador con el lugar J
            DenunciasPorMostrador denunciasPorMostrador = new DenunciasPorMostrador(new DenunciaDeIncendio(J));

            // Invoque al método chispa de los lugares B y F (para que se agreguen denuncias a la lista de DenunciasPorTablero).
            B.chispa();
            F.chispa();

            // PROBADNO FUNCIONAMIENTO
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ATENDIENDO DENUNCIAS POR WHATSAPP!");
            Console.ForegroundColor = ConsoleColor.White;

            op.atenderDenuncias(denunciasPorWhatsapp);
            
            /*
            Console.WriteLine("<13 - ABSTRACT FACTORY");
            Console.WriteLine("BOMBERO:");
            ICuartel cuartelDeBomberos = crearHeroe(new FabricaBombero());
            Bombero b = (Bombero)cuartelDeBomberos.getPersonal();
            b.apagarIncendio(new Casa(10, 10, 10, new Calle(10, 10, 50)));

            Console.WriteLine("MEDICO:");
            ICuartel hospital = crearHeroe(new FabricaMedico());
            Medico m = (Medico)hospital.getPersonal();
            m.atenderInfarto(new Transeunte(0.9, 0.9, 0.9));

            Console.WriteLine("ELECTRICISTA:");
            ICuartel centralElectrica = crearHeroe(new FabricaElectricista());
            Electricista e = (Electricista)centralElectrica.getPersonal();
            e.revisar(new Esquina(10));

            Console.WriteLine("POLICIA:");
            ICuartel comisaria = crearHeroe(new FabricaPolicia());
            Policia p = (Policia)comisaria.getPersonal();
            p.patrullarCalles(new Casa(10, 10, 10, new Calle(10, 10, 50)));

            Policia p2 = (Policia)crearHeroe(new FabricaPolicia()).getPersonal();
            p2.patrullarCalles(new Casa(10, 10, 10, new Calle(10, 10, 50)));

            CuartelDeBomberos cb = CuartelDeBomberos.getInstance();
            IResponsable b1 = cb.getPersonal();
            IResponsable b2 = cb.getPersonal();
            IResponsable b3 = cb.getPersonal();
            IResponsable b4 = cb.getPersonal();
            */
            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
