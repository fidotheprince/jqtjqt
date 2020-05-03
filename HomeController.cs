using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Table.Web.Models;

namespace Table.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(string UserName, string Email, string Password)
        {
            var user = new UserModel();

            //properties set to values passed in by ajax
            //binded to instance & sent by to ajax  for render
            user.Id = 1;
            user.UserName = UserName;
            user.Email = Email;
            user.Password = Password;

            return Json(user, JsonRequestBehavior.AllowGet);
    

        }

    }
}