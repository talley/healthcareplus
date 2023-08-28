using Serilog;
using Serilog.Events;

namespace HCP.Fr.Logging
{
    public static class FilesLogging
    {
        public static void LogToFile(string file, LogEventLevel interval=LogEventLevel.Information, bool useInterval = false)
        {
            if (useInterval)
            {
                Log.Logger = new LoggerConfiguration()
                //.Enrich.With(new ThreadIdEnricher())
               .WriteTo.Console()
               .WriteTo.File(file,interval)
               .CreateLogger();
            }
            else
            {
                Log.Logger = new LoggerConfiguration()
                // .Enrich.With(new ThreadIdEnricher())
           .WriteTo.Console()
           .WriteTo.File(file)
           .CreateLogger();
            }

        }
    }
}
