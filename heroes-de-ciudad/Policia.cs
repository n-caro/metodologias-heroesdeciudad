﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_de_ciudad
{
    class Policia: Responsable, IResponsable
    {
        IOrdenPolicia ordenPolicia = new OPVozDeAlto();

        // getters-setters
        public void setOrdenPolicia(IOrdenPolicia ordenPolicia)
        {
            this.ordenPolicia = ordenPolicia;
        }

        // Métodos
        override public void patrullarCalles(IPatrullable lugarAPatrullar)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("     [POLICIA]       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[POLICIA] ¡Estoy patrullando! [Lugar: {0} ]", lugarAPatrullar);
            //vehiculo.encenderSirena();
            //vehiculo.conducir();
            if (lugarAPatrullar.hayAlgoFueraDeLoNormal())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    HAY UNA AMENAZA PARA LA SEGURIDAD!");
                Console.ForegroundColor = ConsoleColor.Blue;
                //herramienta.usar();
                ordenPolicia.Ejecutar();
                //herramienta.guardar();
            }
            else
            {
                Console.WriteLine("No hay nada fuera de lo normal");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void detenerDelincuente()
        {
            Console.WriteLine("¡Estoy deteniendo un delincuente!");
        }

        // Chain of Responsability
        public Policia(IResponsable r) : base(r)
        {

        }
        public Policia() : base(null)
        {

        }
        // end Chain of responsability
    }
}
