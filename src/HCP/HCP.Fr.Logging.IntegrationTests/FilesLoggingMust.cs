using Serilog.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HCP.Fr.Logging.IntegrationTests
{
    public class FilesLoggingMust
    {
        [Fact]
        public void Output_Exception_To_File()
        {
            Exception exception= null;
            var outputPath = Path.Combine(Directory.GetCurrentDirectory(),"Errors","Errors.txt");
            int a, b, c = 0;
            a = 10;
            b = 0;

            try
            {
                c = a / b;
            }
            catch (Exception ex)
            {
                exception = ex;
                FilesLogging.LogToFile(outputPath, LogEventLevel.Information, true);
                throw ex;
            }
            Assert.Null(exception);
        }
    }
}
