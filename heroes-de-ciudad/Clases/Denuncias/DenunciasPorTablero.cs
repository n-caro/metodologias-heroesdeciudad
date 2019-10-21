using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class DenunciasPorTablero: IDenuncias, IAlarmaIncendioObserver
    {
        private List<IDenuncia> listaDenuncias = new List<IDenuncia>();

        // getter
        public List<IDenuncia> getListaDenuncias()
        {
            return listaDenuncias;
        }
        // Métodos

        public void actualizar(ILugar lugar)
        {
            // Método Observador de alarma de incendio
            listaDenuncias.Add(new DenunciaDeIncendio(lugar));
            Console.WriteLine("Se ha registrado una nueva denuncia por tablero de " + lugar );
        }
        public IteradorDeDenucias crearIterador()
        {
            return new IteradorDenunciasDeTablero(this);
        }
    }
}
