using System;

    /*La clase Greeter es un singleton: solo existe una instancia de esa clase a la cual se accede mediante 
    una propiedad de clase Instance de tipo Greeter. 
    No es posible crear instancias de esa clase porque el constructor Greeter() es privado.
    Esto es útil cuando se necesita exactamente un objeto para coordinar acciones en todo el sistema.*/

namespace Library
{
    public class Greeter
    {

        public void SayHiToTheWorld()
        //void SayHiToTheWorld() que es el verdadero propósito de esta clase.
        {
            Console.WriteLine("Hello World!");
        }
    }
}
