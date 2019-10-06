using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class HeroesDeCiudad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEROES DE CIUDAD");
            Console.WriteLine("<testing>");
            Bombero bomberoRicardo = new Bombero();
            BomberoSecretario bomberoSecretario = new BomberoSecretario(bomberoRicardo);

            // 10 ILugar
            Calle callePrincipal = new Calle(10, 10, 50); // 50 de agua
            Calle calleSecundaria = new Calle(10, 10, 20); // 20 de agua

            Casa A = new Casa(1, 4, 10, callePrincipal);
            Casa B = new Casa(1, 16, 10, callePrincipal);
            Casa C = new Casa(1, 9, 10, calleSecundaria);
            Casa D = new Casa(1, 9, 10, calleSecundaria);
            Casa E = new Casa(1, 16, 10, calleSecundaria);
            Casa F = new Casa(1, 40, 10, calleSecundaria);
            Plaza G = new Plaza("Plaza Principal", 25, 10, 10, callePrincipal);
            Casa H = new Casa(1, 4, 10, calleSecundaria);
            Casa I = new Casa(1, 30, 10, callePrincipal);
            Casa J = new Casa(1, 25, 10, calleSecundaria);


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
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(G), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(H), mensajeswpp);
            mensajeswpp = new MensajeWhatsapp(new DenunciaDeIncendio(I), mensajeswpp);
            DenunciasPorWhatsapp denunciasPorWhatsapp = new DenunciasPorWhatsapp(mensajeswpp);

            // Instancie una DenunciasPorMostrador con el lugar J
            DenunciasPorMostrador denunciasPorMostrador = new DenunciasPorMostrador(new DenunciaDeIncendio(J));

            // Invoque al método chispa de los lugares B y F (para que se agreguen denuncias a la lista de DenunciasPorTablero).
            B.chispa();
            F.chispa();

            // Bombero
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("ATENDIENDO DENUNCIAS POR TABLERO (tiene que ser 2) --> FUNCIONA!");
            Console.ForegroundColor = ConsoleColor.White;
            bomberoSecretario.atenderDenuncias(denunciasPorTablero);

            Console.WriteLine("\n \n \n ---------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ATENDIENDO DENUNCIAS POR WHASTAPP (tiene que ser 3) --> FUNCIONA!");
            Console.ForegroundColor = ConsoleColor.White;
            bomberoSecretario.atenderDenuncias(denunciasPorWhatsapp);

            Console.WriteLine("\n \n \n ---------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ATENDIENDO DENUNCIAS POR Mostrador (tiene que ser 1)");
            Console.ForegroundColor = ConsoleColor.White;
            bomberoSecretario.atenderDenuncias(denunciasPorMostrador);

            // end
            Console.WriteLine("\n ------------------------------- \n No rompiste nada! Presiona una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
