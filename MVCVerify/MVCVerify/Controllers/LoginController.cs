using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVerify.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
			return View();
			//if(ModelState.IsValid == false)
			//{
			//	return View();
			//}
			//return RedirectToAction("home", "index");
        }
		[HttpPost]
		public ActionResult Index(Models.ViewModel.LoginViewModel model)
		{
			if(ModelState.IsValid == false)
			{
				return View();
			}
			return RedirectToAction("index", "home");
		}
    }
}