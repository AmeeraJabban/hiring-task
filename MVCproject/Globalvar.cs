using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVCproject
{
    public  class Globalvar
    {
        public  HttpClient httpclient;
        public Globalvar() {
            httpclient = new HttpClient();
            httpclient.BaseAddress = new Uri("http://localhost:52009/api/");
            httpclient.DefaultRequestHeaders.Clear();
            httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
