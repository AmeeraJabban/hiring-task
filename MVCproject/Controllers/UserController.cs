using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCproject.Controllers.basehttp;
using MVCproject.Models;
using X.PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCproject.Controllers
{
    public class UserController : Controller
    {
        public baseUserHttpController baseHttp;
        protected IHostingEnvironment hosting;
        public UserController(IHostingEnvironment _hosting) {
            this.baseHttp = new baseUserHttpController();
            this.hosting = _hosting;
        }
        // GET: User
        public ActionResult Index(int? page)
        {
            IEnumerable<UserModel> users;
            users = this.baseHttp.get();
            var listPaged = users.ToPagedList(page?? 1 , 10);
            ViewBag.list = listPaged;
            return View();
        }


        public ActionResult AddOrEdit(long id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                UserModel user = this.baseHttp.getById(id);
                return View(user);

            }

        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrEdit(UserModel user)
        {

            if (user.ID==0) {
                if (user.image != null) {
                    string filename = string.Empty;
                    string uploads = Path.Combine(hosting.WebRootPath, "upload");

                    filename = user.image.FileName;
                    string fullpath = Path.Combine(uploads, filename);
                    user.image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    user.imagepath = filename;
                }
               
                this.baseHttp.post(user);
                return RedirectToAction(nameof(Index));
            }
            else {
                this.baseHttp.put(user);
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
            this.baseHttp.delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
