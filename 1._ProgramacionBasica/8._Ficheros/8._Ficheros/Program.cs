namespace _8._Ficheros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leer ficheros ficheros ya existentes
            
            using (StreamReader reader = new StreamReader(@"E:\FullStack\CSharp\CShapCurso\8._Ficheros\8._Ficheros\prueba.txt"))
            {//usamos using destruye todas las variables de la memoria inicializadas dentro de el.
                string text;//crea la variable que contendra el texto
                while((text = reader.ReadLine())!=null)// leemos linea por linea
                {
                    Console.WriteLine(text);
                }
            }

            //leer archivo con File en un solo volcado
            string fileRead = File.ReadAllText(@"E:\FullStack\CSharp\CShapCurso\8._Ficheros\8._Ficheros\prueba.txt");
            Console.WriteLine("Lectura con Clase File {0}",fileRead);

            //Escribir un fichero
            string[] paises = new string[] { "USA", "Inglaterra", "Alemania" };

            using (StreamWriter writer = new StreamWriter(@"E:\FullStack\CSharp\CShapCurso\8._Ficheros\8._Ficheros\escribirFichero.txt"))
            {
                foreach (string item in paises)
                {
                    writer.WriteLine(item);
                }
            }

            //Escribir fichero con Tipo File
            string[] countries = new string[] { "USA", "Inglaterra", "Alemania" };
            File.WriteAllText(@"E:\FullStack\CSharp\CShapCurso\8._Ficheros\8._Ficheros\escribirFicheroWithFile.txt", "China \n japon \n korea"); //escribe texto en un solo volcado
            File.WriteAllLines(@"E:\FullStack\CSharp\CShapCurso\8._Ficheros\8._Ficheros\escribirFicheroWithFile.txt", paises); //escribira por línea cada uno de los elementos que mandamos en el Array
        }
    }
}