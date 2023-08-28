using Serilog.Core;
using Serilog.Events;
using System.Threading;

namespace HCP.Fr.Logging
{
    public class ThreadIdEnricher
    {
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty(
                    "ThreadId", Thread.CurrentThread.ManagedThreadId));
        }
    }
}
