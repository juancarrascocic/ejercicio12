using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    public class CafeteraSingleton
    {
        /*Si lo hacemos de esta manera, nos ahorramos el problema de la concurrencia, pero
         * tenemos que entrar en consctructores estaticos. Tambien con esto tenemos el problema de que la clase 
         * se instancia justo cuando se carga la clase, asi que
         * no controlamos la creacion de la instancia.
         * */
        //private static CafeteraSingleton instance = new CafeteraSingleton();

        private static CafeteraSingleton instance;

        private CafeteraSingleton()
        {
            // Constructor privado para que no se pueda llamar desde fuera
        }

        public static CafeteraSingleton getInstance()
        { 
            // si dos hilos acceden a getInstance a la vez, cuando no se ha instanciado, 
            // tenemos un problema
            if (instance == null) // Como hace referencia a un objeto, comparamos con null
            {
                instance = new CafeteraSingleton();
            }
            return instance;
        }
    }

}
