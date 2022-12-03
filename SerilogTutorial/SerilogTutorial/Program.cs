using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace SerilogTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code)
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

            Log.CloseAndFlush();
        }

        static void ThrowError()
        {
            throw new NullReferenceException();
        }
    }
}