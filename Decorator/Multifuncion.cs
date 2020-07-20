using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Multifuncion : IComponentesBasicos
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo");
        }

        public void Escanear()
        {
            Console.WriteLine("Escanear");
        }
    }
}
