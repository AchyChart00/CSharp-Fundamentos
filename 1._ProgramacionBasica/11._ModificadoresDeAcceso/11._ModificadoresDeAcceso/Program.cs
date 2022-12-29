namespace _11._ModificadoresDeAcceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClasePublicaEjemplo modificadorPublic = new ClasePublicaEjemplo();
            modificadorPublic.PruebaAccesoPublico = "Hola mundo";//Modificador de acceso público, Puede obtener acceso al tipo o miembro cualquier otro código del mismo ensamblado o de otro ensamblado
                                                                 //que haga referencia a este. El nivel de accesibilidad de los miembros públicos de un tipo se controla mediante el nivel de accesibilidad
                                                                 //del propio tipo
            //modificadorPublic.PruebaAccesoPrivate="No disponible xC" //Modificador de acceso privado, Solamente el código de la misma class o struct puede acceder al tipo o miembro. 



        }
    }
}