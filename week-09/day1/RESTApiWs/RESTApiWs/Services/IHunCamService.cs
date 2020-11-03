using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Services
{
    public interface IHunCamService
    {
        public string Camellizer(string text, string lang);
    }
}
