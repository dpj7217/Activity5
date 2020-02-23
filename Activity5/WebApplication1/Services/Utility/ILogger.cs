using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2Part3.Services.Utility
{
    public interface ILogger
    {
        void Debug(string Message);
        void Info(string Message);
        void Warning(string Message);
        void Error(string Message);
    }
}
