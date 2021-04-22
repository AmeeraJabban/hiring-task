using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCproject.Controllers.basehttp
{
    public class baseUserHttpController : Controller
    {
        public HttpResponseMessage response;
        public Globalvar globalvar;

       public baseUserHttpController() {
            response = new HttpResponseMessage();
            globalvar = new Globalvar();
        }
        public IEnumerable<UserModel> get()
        {
            response = globalvar.httpclient.GetAsync("user").Result;
            return response.Content.ReadAsAsync<IEnumerable<UserModel>>().Result;
        }
        public UserModel getById(long id)
        {
            response = globalvar.httpclient.GetAsync("user/"+id.ToString()).Result;
            return response.Content.ReadAsAsync<UserModel>().Result;
        }
        public void post(UserModel user)
        {
            response = globalvar.httpclient.PostAsJsonAsync("user",user).Result;
        }
        public void put(UserModel user)
        {
            response = globalvar.httpclient.PutAsJsonAsync("user", user).Result;
        }
        public void delete(long id)
        {
            response = globalvar.httpclient.DeleteAsync("user/" + id.ToString()).Result;
        }
    }
}
