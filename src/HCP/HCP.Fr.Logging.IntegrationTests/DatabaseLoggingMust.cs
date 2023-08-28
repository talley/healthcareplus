using HCP.Fr.Dao.Repository;
using HCP.Fr.DS.Logs;
using System;
using Xunit;
using HCP.Fr.Logging;

namespace HCP.Fr.Logging.IntegrationTests
{
    public class DatabaseLoggingMust
    {
        private IRepository<ExceptionLogs> repos = new ExceptionLogsRepository();
        [Fact]
        public void Create_Table()
        {
            int result;
            var cs = @"Data Source=.;Initial Catalog=HCPFR_Logs;Integrated Security=True";
            var app = "HCP";
            var code = "DatabaseLoggingMust/Create_Table";
            Exception myex = new Exception();
            try
            {
                var a = 90;
                var b = 0;
                result = a/b;
            }
            catch (Exception ex)
            {
                ex.LogToDb("DatabaseLoggingMust/()", "DatabaseLoggingMust.cs","test@test.com",
                    "HCPFR");
                myex = ex;
                throw ex;
            }

            Assert.NotNull(myex);
        }
    }
}
