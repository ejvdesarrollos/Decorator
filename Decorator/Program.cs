using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponentesBasicos unaImpresora = new Multifuncion();
            //Actúo con la implementación de la interfaz
            unaImpresora.Imprimir();

            //Pero a modo "decorator" le agrego comportamiento sin que exista en la Interfaz.
            ((Multifuncion)unaImpresora).Escanear();
        }
    }
}
