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
    public class TransactionController : ControllerBase
    {
        public TransactionService svc;

        public TransactionController(TransactionService _svc)
        {
            svc = _svc;
        }
        // GET: api/<TransController>
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return svc.getAll().ToList();
        }

        // GET api/<TransController>/5
        [HttpGet("{id}")]
        public Transaction Get(long id)
        {
            return svc.getByID(id);
        }

        // POST api/<TransController>
        [HttpPost]
        public void Post([FromBody] Transaction transaction)
        {
            svc.Add(transaction);
        }

        // PUT api/<TransController>/5
        [HttpPut]
        public void Put([FromBody] Transaction transaction)
        {
            svc.Edit(transaction);
        }

        // DELETE api/<TransController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            svc.Delete(id);
        }
    }
}
