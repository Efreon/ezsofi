using Microsoft.AspNetCore.Mvc;
using RESTApiWs.Database;
using RESTApiWs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Services
{
    public class LogService :ILogService
    {
        public readonly ApiDbContext dbContext;
        public LogService(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void LogRequest(string endpoint, string data)
        {
            dbContext.Logs.Add(new Models.Log(endpoint, data));
            dbContext.SaveChanges();
        }
        public List<Log> GetLogs()
        {
            return dbContext.Logs.ToList();
        }

    }
}
