namespace _13._HttpClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //HTTPClient
            //Es una clase que nos proporciona hacer llamadas a través
            //del protocolo HTTP
            await verEstadoHttp();
        }

        static async Task<string> verEstadoHttp()
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync("https://www.netmentor.es");
                Console.WriteLine($"la respuesta fue: {result.StatusCode}");
                Console.WriteLine("Hola mundo");

                return "Hola mundo";
            }
        }
    }
}