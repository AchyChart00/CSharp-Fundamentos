using System;

namespace _11._TiposNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int enteroNulo = null;
            //En c# no podemos declara variables nulas
            //Para permitirnos que una variable sea de tipo null
            //necesitamos agregar el simbolo ? despues de la palabra reservada del tipo de dato

            int? enteroNulo = null;
            enteroNulo = 123;

            int enteroNormal = 234;
            //enteroNormal = enteroNulo;
            //no podemos asignar valor de int?, tenemos que castear
            enteroNormal = (int)enteroNulo;

            //los tipos nulos nos dejan acceder a ciertas propiedades. 
            // como hasValue, la cual nos dice si contiene valor o si es un null. 
            // para finalmente acceder a la propiedad Value, que nos dara el valor de esa variable si no es un nulo. 

            if (enteroNulo.HasValue)
            {
                enteroNormal = enteroNulo.Value;
            }


        }
    }
}
