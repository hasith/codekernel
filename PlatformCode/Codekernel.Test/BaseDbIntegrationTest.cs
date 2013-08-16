using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codekernel.Data;
using Codekernel.Model;
using System.IO;
using System.Linq;
using System.Configuration;
using Codekernel.Data.Core;
using System.Diagnostics;


namespace Codekernel.Test
{
    public class BaseDbIntegrationTest
    {
        
        protected static void DeleteDbFile()
        {
            //set Data Directory for the connection string to use
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Empty));

            //lets delete any existing database files
            var databaseFile = Path.Combine((string)AppDomain.CurrentDomain.GetData("DataDirectory"), "CodekernelDatabase.mdf");
            var databaseLogFile = Path.Combine((string)AppDomain.CurrentDomain.GetData("DataDirectory"), "CodekernelDatabase_log.ldf");
            File.Delete(databaseFile);
            File.Delete(databaseLogFile);
        }

        
    }
}
