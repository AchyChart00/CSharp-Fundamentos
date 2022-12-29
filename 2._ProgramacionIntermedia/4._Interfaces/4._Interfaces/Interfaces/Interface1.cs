using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _4._Interfaces.Interfaces
{
    internal interface IPizza
    {
        //Las interfaces son un tipo de contrato entre dos entidades, de este modo la interface solo indica a la clase donde se implementa que metodos debe de tener más no como se van a implementar cada método.
        //Las interfaces no contienen constructores

        /*Cuando implementamos una interfaz debemos de asegurar un par de puntos:

           * Los métodos y tipos que devuelven deben coincidir tanto en la interfaz como en la clase.
           * Deben ser los mismos parámetros
           * Los métodos de la interfaz deben ser públicos
           * La utilización de interfaces mejora el código y el rendimiento de la aplicación.*/

        decimal Area();
        decimal Perimetro();
    }
}
