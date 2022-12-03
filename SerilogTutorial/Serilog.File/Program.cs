using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Configuro Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(@"E:\FullStack\CSharp\CShapCurso\SerilogTutorial\Serilog.File\Logs\log.txt")
                .CreateLogger();

            try
            {
                Log.Debug("Application is Starting...");
                Log.Information("Hello {Name}!", Environment.GetEnvironmentVariable("USERNAME"));
                Log.Warning("You shouldn't be allowed here");
                ThrowError();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            //Cierro Serilog
            Log.CloseAndFlush();
        }

        static void ThrowError()
        {
            throw new NullReferenceException();
        }
    }
}