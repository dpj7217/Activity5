using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WebApplication1.Services.Business
{
    public interface ITestService
    {
        void Initialize(Activity2Part3.Services.Utility.ILogger logger);
        void TestLogger();
    }
}
