using RESTApiWs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Services
{
    public interface ILogService
    {
        public void LogRequest(string endpoint, string data);
        public List<Log> GetLogs();
    }
}
