using Microsoft.AspNetCore.Mvc;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCproject.Controllers.basehttp
{
    public class baseTransactionHttpController : Controller
    {
        public HttpResponseMessage response;
        public Globalvar globalvar;

        public baseTransactionHttpController()
        {
            response = new HttpResponseMessage();
            globalvar = new Globalvar();
        }
        public IEnumerable<TransactionModel> get()
        {
            response = globalvar.httpclient.GetAsync("Transaction").Result;
            return response.Content.ReadAsAsync<IEnumerable<TransactionModel>>().Result;
        }
        public TransactionModel getById(long id)
        {
            response = globalvar.httpclient.GetAsync("Transaction/" + id.ToString()).Result;
            return response.Content.ReadAsAsync<TransactionModel>().Result;
        }
        public void post(TransactionModel Transaction)
        {
            response = globalvar.httpclient.PostAsJsonAsync("Transaction", Transaction).Result;
        }
        public void put(TransactionModel Transaction)
        {
            response = globalvar.httpclient.PutAsJsonAsync("Transaction", Transaction).Result;
        }
        public void delete(long id)
        {
            response = globalvar.httpclient.DeleteAsync("Transaction/" + id.ToString()).Result;
        }
    }
}
