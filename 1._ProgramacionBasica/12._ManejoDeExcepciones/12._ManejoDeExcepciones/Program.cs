namespace _12._ManejoDeExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una Excepción es un problema o error que aparece de una manera repentina en nuestro código mientras se esta ejecutando. 
            //C# ofrece los comando try-catch para tener un manejo de las excepciones.

            try
            {
                operacionDivision();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void operacionDivision()
        {
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                decimal division = 25 / numero;
            }
            catch (FormatException ex)
            {
                //throw;//Permite enviar la excepcion padre, en este caso envíara la excepción a niveles superiores. 
                Console.WriteLine("El valor introducido no era un numero entero");

            }//También es posible especificar excepciones y agregar tantos catch como deseemos
            catch(DivideByZeroException ex)
            {
                Console.Write("No es posible dividir por 0");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
        }
    }
}