using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace Activity2Part3.Services.Utility
{
    public class MyLogger2 : ILogger
    {
        private Lazy<NLog.Logger> theirLogger;

   
        public Lazy<NLog.Logger> GetLogger()
        {
            return theirLogger = new Lazy<NLog.Logger>(() => { return LogManager.GetLogger("myAppLoggerRules"); });
        }

        public void Debug(string message)
        {
            this.GetLogger().Value.Debug(message);
        }

        public void Info(string message)
        {
            this.GetLogger().Value.Info(message);
        }

        public void Warning(string message)
        {
            this.GetLogger().Value.Warn(message);
        }

        public void Error(string message)
        {
            this.GetLogger().Value.Error(message);
        }
    }
}