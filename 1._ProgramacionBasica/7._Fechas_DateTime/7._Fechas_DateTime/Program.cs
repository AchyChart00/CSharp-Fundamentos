using System.Data;
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

            //Convertir string a fechas
            //Tenemos dos opciones para convetir string a fecha
            string fechaHoy = "10/22/2015 12:10:15 PM";
            DateTime fechaConvert = Convert.ToDateTime(fechaHoy);

            //Parse es recomendado por la amplia compatibilidad y conversión aumatica de fechas.
            DateTime fechaParse = DateTime.Parse(fechaHoy);

            //Fecha de acuerdo a localización
            CultureInfo cultureInfoES = new CultureInfo("es-SP");
            CultureInfo cultureInfoMX = new CultureInfo("es-MX");
            CultureInfo cultureInfoUS = new CultureInfo("en-US");

            Console.WriteLine($"Formato de fecha España: {Convert.ToDateTime(fechaParse, cultureInfoES)}");
            Console.WriteLine($"Formato de fecha México: {Convert.ToDateTime(fechaParse, cultureInfoMX)}");
            Console.WriteLine($"Formato de fecha Estados Unidos: {Convert.ToDateTime(fechaParse, cultureInfoUS)}");

            //Propiedades del tipo DateTime
            //Obtenemos la fecha del día de hoy con Now
            DateTime fechaProp = DateTime.Now;
            int dia = fechaProp.Day;
            Console.WriteLine($"Día {dia}");
            int mes = fechaProp.Month;
            Console.WriteLine($"Mes {mes}");
            int year= fechaProp.Year;
            Console.WriteLine($"Año {year}");
            int hora = fechaProp.Hour;
            Console.WriteLine($"Hora {hora}");
            int minuto = fechaProp.Minute;
            Console.WriteLine($"Minuto {minuto}");
            int segundo = fechaProp.Second;
            Console.WriteLine($"Segundo {segundo}");
            string diaSemana = fechaProp.DayOfWeek.ToString();
            Console.WriteLine($"Dia de la semana {diaSemana}");
            int dayOfYear = fechaProp.DayOfYear;
            Console.WriteLine($"Día del año {dayOfYear}");
            DateTime tiempo = fechaProp.Date;
            Console.WriteLine($"Fecha del día de hoy {tiempo}");

            //Métodos del tipo dateTime
            //Nos permiten añadir días, meses o incluso tiempo
            //Añadir días
            fechaProp.AddDays( 1 );
            fechaProp.AddMonths( 1 );
            fechaProp.AddYears(1);

            //También podemos restar días, meses, años. etc.
            fechaProp.AddDays(-1);
            fechaProp.AddMonths(-1);
            fechaProp.AddYears(-1);

            //TimeSpan
            //Sirve para poder trabajar con tiempos.
            //creación de instancia DateTime
            DateTime fecha = new DateTime(2019,01,01);
            Console.WriteLine($"instancia de objeto DateTime {fecha}");

            //instancia del objeto TimeSpan
            TimeSpan tiempoSpan = new TimeSpan(1, 5, 30, 5);
            Console.WriteLine($"instancia de objeto TimeSpan {tiempoSpan}");

            DateTime fechaActualizada = fecha.Add(tiempoSpan);
            Console.WriteLine($"Fecha Actualizada {fechaActualizada}");


            //Comparación de fecha
            //Para poder realizar la compración de fecha 
            
            //Primera opción Metodo de DateTime
            int isEqual = DateTime.Compare( fechaActualizada, fecha);
            if (isEqual == 0)
            {
                Console.WriteLine($"fechaActualizada: {fechaActualizada} y fecha son iguales {fecha}");
            }else if (isEqual < 0)
            {
                Console.WriteLine($"fechaActualizada: {fechaActualizada} es menor a fecha {fecha}");
            }
            else
            {
                Console.WriteLine($"FechaActualizada {fechaActualizada} es mayor en fecha {fecha}");
            }

            //Segunda opción de comparación de fechas
            int fechaResultado = fechaActualizada.CompareTo( fecha);
            if (fechaResultado == 0)
            {
                Console.WriteLine($"fechaActualizada: {fechaActualizada} y fecha son iguales {fecha}");
            }
            else if (fechaResultado < 0)
            {
                Console.WriteLine($"fechaActualizada: {fechaActualizada} es menor a fecha {fecha}");
            }
            else
            {
                Console.WriteLine($"FechaActualizada {fechaActualizada} es mayor en fecha {fecha}");
            }

            //Imprimir fechas con formato
            DateTime fechaFormato = new DateTime(1989, 11, 2, 11, 15, 16);
            Console.WriteLine($"Fecha con hora: {fechaFormato.ToString()}");
            Console.WriteLine($"Fecha: {fechaFormato.ToShortDateString()}");
            Console.WriteLine($"Fecha larga: {fechaFormato.ToLongDateString()}");
            Console.WriteLine($"Hora corta: {fechaFormato.ToShortTimeString()}");

            //utilizando .ToString para conversión de fechas
            DateTime fechaToString = new DateTime(1989, 11, 2, 11, 15, 16, 123);
            Console.WriteLine($"Utilizando Fecha con metodo ToString() {fechaToString.ToString("yyyy-MM-ddThh:mm:ss.ms")}");
        }
    }
}