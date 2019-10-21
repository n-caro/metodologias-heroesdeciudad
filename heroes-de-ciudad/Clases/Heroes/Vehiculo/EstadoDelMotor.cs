using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    abstract class EstadoDelMotor
    {
        protected Vehiculo vehiculo;

        public EstadoDelMotor(Vehiculo v)
        {
            vehiculo = v;
        }

        virtual public void acelerar()
        {
            Console.WriteLine("Sin efecto");
        }

        virtual public void desacelerar()
        {
            Console.WriteLine("Sin efecto");
        }

        virtual public void frenar()
        {
            Console.WriteLine("Sin efecto");
        }

        virtual public void encender()
        {
            Console.WriteLine("Sin efecto");
        }
    }

    /// Estados del motor
    /// Clases: 
    class Apagado : EstadoDelMotor
    {
        public Apagado(Vehiculo v) : base(v) { }

        override public void encender()
        {
            Console.WriteLine("Encendiendo motor");

            vehiculo.setEstado(new PuntoMuerto(vehiculo));
        }
    }

    class PuntoMuerto : EstadoDelMotor
    {
        public PuntoMuerto(Vehiculo v) : base(v) { }

        override public void acelerar()
        {
            Console.WriteLine("acelerando a marcha lenta");

            vehiculo.setEstado(new MarchaLenta(vehiculo));
        }
    }

    class MarchaLenta : EstadoDelMotor
    {
        public MarchaLenta(Vehiculo v) : base(v) { }

        override public void acelerar()
        {
            Console.WriteLine("acelerando a media marcha");

            vehiculo.setEstado(new MediaMarcha(vehiculo));
        }

        override public void desacelerar()
        {
            Console.WriteLine("desacelerando a punto muerto");

            vehiculo.setEstado(new PuntoMuerto(vehiculo));
        }

        override public void frenar()
        {
            Console.WriteLine("frenando");

            vehiculo.setEstado(new PuntoMuerto(vehiculo));
        }
    }

    class MediaMarcha : EstadoDelMotor
    {
        public MediaMarcha(Vehiculo v) : base(v) { }

        override public void acelerar()
        {
            Console.WriteLine("acelerando a toda marcha");

            vehiculo.setEstado(new TodaMarcha(vehiculo));
        }

        override public void desacelerar()
        {
            Console.WriteLine("desacelerando a marcha lenta");

            vehiculo.setEstado(new MarchaLenta(vehiculo));
        }

        override public void frenar()
        {
            Console.WriteLine("frenando");

            vehiculo.setEstado(new PuntoMuerto(vehiculo));
        }
    }

    class TodaMarcha : EstadoDelMotor
    {
        public TodaMarcha(Vehiculo v) : base(v) { }

        override public void acelerar()
        {
            Console.WriteLine("rompiendo el motor");

            vehiculo.setEstado(new Roto(vehiculo));
        }

        override public void desacelerar()
        {
            Console.WriteLine("desacelerando a media marcha");

            vehiculo.setEstado(new MediaMarcha(vehiculo));
        }

        override public void frenar()
        {
            Console.WriteLine("frenando");

            vehiculo.setEstado(new PuntoMuerto(vehiculo));
        }
    }

    class Roto : EstadoDelMotor
    {
        public Roto(Vehiculo v) : base(v) { }

        override public void acelerar()
        {
            Console.WriteLine("clack crunch paff");
        }

        override public void desacelerar()
        {
            Console.WriteLine("clack crunch paff");
        }

        override public void frenar()
        {
            Console.WriteLine("clack crunch paff");
        }
    }
}
