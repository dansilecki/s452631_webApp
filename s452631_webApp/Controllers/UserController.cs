using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using s452631_webApp.Models;

namespace s452631_webApp.Controllers
{
    public class UserController : Controller
    {
        DataClasses1DataContext dataClass = new DataClasses1DataContext();
        // GET: User
        public ActionResult Index()
        {
            //var userList = dataClass.users.ToList();
            var userList = (from xxx in dataClass.users where xxx.isDeleted == false select xxx).ToList();
            return View(userList);
        }

        public ActionResult Details(int id)
        {
            var displayUser = (from xxx in dataClass.users where xxx.id == id select xxx).FirstOrDefault();
            return View(displayUser);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(users newUser)
        {
            dataClass.users.InsertOnSubmit(newUser);
            dataClass.SubmitChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            var deleteUser = (from xxx in dataClass.users where xxx.id == id select xxx).FirstOrDefault();
            deleteUser.isDeleted = true;
            dataClass.SubmitChanges();

            return RedirectToAction("Index");
            //return View(deleteUser);
        }
    }
}