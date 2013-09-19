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

        public BaseDbIntegrationTest()
        {
            //set Data Directory for the connection string to use
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Empty));
        }

        protected static void DeleteDbFile()
        {
            var databaseFile = Path.Combine((string)AppDomain.CurrentDomain.GetData("DataDirectory"), "CodekernelDatabase.mdf");
            var databaseLogFile = Path.Combine((string)AppDomain.CurrentDomain.GetData("DataDirectory"), "CodekernelDatabase_log.ldf");
            File.Delete(databaseFile);
            File.Delete(databaseLogFile);
        }

        
    }
}
