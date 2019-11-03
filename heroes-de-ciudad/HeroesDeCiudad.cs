using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heroes_de_ciudad.Testing;

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
            Test_HeroesDeCiudad.tituloDecorado();
            // heroes
            BomberoProxy bombero = new BomberoProxy();
            MedicoProxy medico = new MedicoProxy();
            PoliciaProxy policia = new PoliciaProxy();
            ElectricistaProxy electricista = new ElectricistaProxy();
            // creo Cadena
            medico.setSiguiente(bombero);
            policia.setSiguiente(medico);
            electricista.setSiguiente(policia);

            Operador911 op = new Operador911(electricista);

            // armar cadena?

            // 10 ILugar
            DirectorDeSectores directorFavorable = new DirectorDeSectores(new ConstructorDesfavorable());

            Calle callePrincipal = new Calle(11, 10, 50); // 50 de agua
            Calle calleSecundaria = new Calle(15, 10, 30); // 20 de agua

            Casa A = new Casa(1, 4, 10, callePrincipal, directorFavorable);
            Casa B = new Casa(1, 16, 10, callePrincipal, directorFavorable);
            Casa C = new Casa(1, 9, 10, calleSecundaria, directorFavorable);
            Casa D = new Casa(1, 9, 10, calleSecundaria, directorFavorable);
            Casa E = new Casa(1, 16, 10, calleSecundaria, directorFavorable);
            Casa F = new Casa(1, 40, 10, calleSecundaria, directorFavorable);
            Plaza G = new Plaza("Plaza Alemana", 100, 10, 10, callePrincipal, directorFavorable);
            Casa H = new Casa(1, 72, 10, calleSecundaria, directorFavorable);
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
            Console.WriteLine("\n \n ---------------------------- \n  ATENDIENDO DENUNCIAS POR WHATSAPP! \n ---------------------------- \n ");
            Console.ForegroundColor = ConsoleColor.White;

            op.atenderDenuncias(denunciasPorWhatsapp);
            
            Console.WriteLine("\n ------------------------------- \n Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
