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
    public class TransactionController : Controller
    {
        public baseTransactionHttpController baseHttp;
        public TransactionController()
        {
            baseHttp = new baseTransactionHttpController();
        }
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<TransactionModel> Transactions;
            Transactions = baseHttp.get();
            return View(Transactions);


        }


        public ActionResult AddOrEdit(long id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                TransactionModel Transaction = baseHttp.getById(id);
                return View(Transaction);

            }

        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrEdit(TransactionModel Transaction)
        {
            if (Transaction.ID == 0)
            {
                baseHttp.post(Transaction);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                baseHttp.put(Transaction);
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
