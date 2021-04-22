using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCproject.Controllers.basehttp
{
    public class baseAccountHttpController : Controller
    {
        public HttpResponseMessage response;
        public Globalvar globalvar;

        public baseAccountHttpController()
        {
            response = new HttpResponseMessage();
            globalvar = new Globalvar();
        }
        public IEnumerable<AccountModel> get()
        {
            response = globalvar.httpclient.GetAsync("Account").Result;
            return response.Content.ReadAsAsync<IEnumerable<AccountModel>>().Result;
        }
        public AccountModel getById(long id)
        {
            response = globalvar.httpclient.GetAsync("Account/" + id.ToString()).Result;
            return response.Content.ReadAsAsync<AccountModel>().Result;
        }
        public void post(AccountModel Account)
        {
            response = globalvar.httpclient.PostAsJsonAsync("Account", Account).Result;
        }
        public void put(AccountModel Account)
        {
            response = globalvar.httpclient.PutAsJsonAsync("Account", Account).Result;
        }
        public void delete(long id)
        {
            response = globalvar.httpclient.DeleteAsync("Account/" + id.ToString()).Result;
        }
    }
}
