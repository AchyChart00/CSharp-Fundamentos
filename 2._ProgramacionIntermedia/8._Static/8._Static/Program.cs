namespace _8._Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Una clase estatica no puede ser instanciada
            //debemos de incluir todos los miembros como estaticos
            //No se puede incluir un constructor dentro de una clase estatica
            int resultadoSuma = Calculadora.Suma(1,2);
            Console.WriteLine(resultadoSuma);

            int resultadoSumaMetodo = CalculadoraMetodoEstatico.Suma(1,2);
            CalculadoraMetodoEstatico calc = new CalculadoraMetodoEstatico();
            CalculadoraMetodoEstatico calc2 = new CalculadoraMetodoEstatico();
            double media1 = calc.Media(new List<int>() { 1,2,3,4,5,6});
            double media2 = calc2.Media(new List<int>() { 1, 2, 3, 4, 5, 6,7,8,9,10 });
            

            Console.WriteLine(media1);
            Console.WriteLine(media2);

            calc.SumaNumeroStatic(5);
            calc2.SumaNumeroStatic(10);
            calc.SumaNumeroStatic(10);

            calc.SumaNumeroNoStatic(5);
            calc2.SumaNumeroNoStatic(10);
            calc.SumaNumeroNoStatic(10);

            Console.WriteLine(calc.obtenerNumeroStatic());
            Console.WriteLine(calc.obtenerNumeroNoStatic());

            Console.WriteLine(calc2.obtenerNumeroStatic());
            Console.WriteLine(calc2.obtenerNumeroNoStatic());


        }
    }
}