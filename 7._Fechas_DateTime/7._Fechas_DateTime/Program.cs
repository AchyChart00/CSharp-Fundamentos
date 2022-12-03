using System.Globalization;

namespace _7._Fechas_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tenemos multitud de opciones al crear el objeto Datetime
            /*public DateTime(long ticks);
            public DateTime(long ticks, DateTimeKind kind);
            public DateTime(int year, int month, int day);
            public DateTime(int year, int month, int day, Calendar calendar);
            public DateTime(int year, int month, int day, int hour, int minute, int second);
            public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind);
            public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar);
            public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond);
            public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind);
            public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar);
            public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind);
            */
                                                
            DateTime EjemploFecha = new DateTime(2019, 02, 10, 11, 15, 16);
            Console.WriteLine($"La fecha es: {EjemploFecha}");
        }
    }
}