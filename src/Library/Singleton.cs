using System;

namespace Library
{
    
    public class Singleton<T> where T: new()
    //Al generar la clase se instancia T de manera unica
    {
            
        private static T instance;

        private Singleton() 
        {      
        }
        
        public static T Instance
        /*Al acceder por primera vez a la propiedad de clase Instance 
        se crea la única instancia y se guarda en la variable de clase privada instance
        Luego cada vez que se accede a la propiedad de clase Instance se retorna esa única instancia.*/
        {
            get
            {
                if (instance == null)
                {
                    instance = new T ();
                }

                return instance;

            }
        }
    } 
}
