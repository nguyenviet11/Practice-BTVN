using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice2_S5.Models;

namespace Practice2_S5.Controllers
{
    public class UserController : Controller
    {
        private static List<UserModel> _users = new List<UserModel>();
        // GET: User
        public ActionResult Index()
        {
            return View(_users);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            UserModel user =  _users.Find(emp => emp.Idd == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                UserModel u = new UserModel();
                u.Idd = Int32.Parse(collection["Idd"]);
                u.ConfirmPassword = collection["ConfirmPassword"];
                u.Email = collection["email"];  
                u.Password = collection["password"];
                u.Name = collection["name"];
                _users.Add(u);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}