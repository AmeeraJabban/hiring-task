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
    public class UserController : ControllerBase
    {
        private UserService svc;

        public UserController(UserService _svc)
        {
            svc = _svc;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return svc.getAll().ToList();
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public User Get(long id)
        {
            return svc.getByID(id);
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            svc.Add(user);
        }

        // PUT api/<AccountController>/5
        [HttpPut]
        public void Put([FromBody] User user)
        {
            svc.Edit(user);
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            svc.Delete(id);
        }
    }
}
