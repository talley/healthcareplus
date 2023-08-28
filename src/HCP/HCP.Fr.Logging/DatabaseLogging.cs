using Microsoft.Data.SqlClient;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Data;
using Dapper;
using HCP.Fr.DS.Logs;
using HCP.Fr.Dao.Repository;
using MoreLinq;
using MoreLinq.Extensions;
using MoreLinq.Experimental;
using HCP.Fr.Logging.Helpers;

namespace HCP.Fr.Logging
{
    public static class DatabaseLogging
    {
        private static IRepository<ExceptionLogs> repos = new ExceptionLogsRepository();
        public static void LogExceptionToDatabase(string cs,Exception ex,string table,string appName,string code)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo
            .MSSqlServer(
                connectionString: cs,
                sinkOptions: new MSSqlServerSinkOptions { TableName = table,AutoCreateSqlTable=true })
            .CreateLogger();

            Log.Error(ex,$"Cette erreur s'est produite sur l`application {appName},code:{code}");
        }

        public static void LogToDb(this Exception ex,string method,string codeFile,string email,string appName="HCO")
        {
            int result = 0;

            try
            {
                var data = new ExceptionLogs {
                    ajouter_au=CommonHelpers.GetEuDate(),
                    ajouter_par=CommonHelpers.GetSystemUserName(email) ,
                    application=appName,
                    HelpURL=ex.HelpLink,
                    HResult=ex.HResult,
                    Id=0,
                    Message=ex.Message,
                    Nom_de_fichier=codeFile,
                    Source=ex.Source,
                    nom_de_la_méthode=method,
                    trace_de_la_pile=ex.StackTrace
                };
                result = repos.SaveOrUpdate(data);
            }
            catch (Exception exs) when(exs!=null)
            {

                throw exs;
            }
        }
    }
}
