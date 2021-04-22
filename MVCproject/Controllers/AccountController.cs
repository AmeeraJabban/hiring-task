using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCproject.Controllers.basehttp;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCproject.Controllers
{
    public class AccountController : Controller
    {
        public baseAccountHttpController baseHttp;
        public AccountController()
        {
            baseHttp = new baseAccountHttpController();
        }
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<AccountModel> Account;
            Account = baseHttp.get();
            return View(Account);


        }


        public ActionResult AddOrEdit(long id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                AccountModel Account = baseHttp.getById(id);
                return View(Account);

            }

        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrEdit(AccountModel Account)
        {
            if (Account.ID == 0)
            {
                baseHttp.post(Account);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                baseHttp.put(Account);
                return RedirectToAction(nameof(Index));
            }

        }


        // GET: User/Delete/5
        public ActionResult Delete(long id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, IFormCollection collection)
        {
            baseHttp.delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
