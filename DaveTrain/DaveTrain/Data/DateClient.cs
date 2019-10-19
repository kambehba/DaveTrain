using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DaveTrain.Data
{
    public class DateClient
    {
        public DateClient(HttpClient c)
        {
            Client = c;
        }
        public HttpClient Client { get; set; }
    }
}
