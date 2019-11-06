using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
   abstract class Vehiculo
    {
        EstadoDelMotor estado;


        public Vehiculo()
        {
            estado = new Apagado(this);
        }

        public void setEstado(EstadoDelMotor e)
        {
            estado = e;
        }

        public void acelerar()
        {
            estado.acelerar();
        }

        public void desacelerar()
        {
            estado.desacelerar();
        }

        public void frenar()
        {
            estado.frenar();
        }

        public void encender()
        {
            estado.encender();
        }

        public void simularConduccion()
        {
            encender();
            acelerar();
            acelerar();
            desacelerar();
            frenar();
            acelerar();
            acelerar();
            acelerar();
            desacelerar();
            frenar();
        }
    }
}
