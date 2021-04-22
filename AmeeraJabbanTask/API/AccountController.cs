using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmeeraJabbanTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AccountService svc;

        public AccountController(AccountService _svc)
        {
            svc = _svc;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return svc.getAll().ToList();
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public Account Get(long id)
        {
            return svc.getByID(id);
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] Account account)
        {
            svc.Add(account);
        }

        // PUT api/<AccountController>
        [HttpPut]
        public void Put([FromBody] Account account)
        {
            svc.Edit(account);
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            svc.Delete(id);
        }
    }
}
