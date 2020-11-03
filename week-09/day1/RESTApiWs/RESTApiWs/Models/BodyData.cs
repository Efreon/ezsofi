using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Models
{
    public class BodyData
    {
        public int? Until {get; set;}

        public string What { get; set; }
        public int[] Numbers { get; set; }
        public string Text { get; set; }


    }
}
