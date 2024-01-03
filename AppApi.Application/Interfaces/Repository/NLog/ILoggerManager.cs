using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Application.Interfaces.Repository.NLog
{
    public interface ILoggerManager
    {
        void LogError(string message);
        void LogWarnig(string message);
        void LogDebug(string message);
        void LogInfo(string message);
    }
}
