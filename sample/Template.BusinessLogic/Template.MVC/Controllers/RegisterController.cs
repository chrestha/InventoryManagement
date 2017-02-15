using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Template.Model;

namespace Template.MVC.Controllers
{
    public class RegisterController : Controller
    {
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Index(RegisterModel objRegisterModel)
        {
            var registerbusiness = new Template.BusinessLogic.RegisterBusiness();

            if (registerbusiness.FindUser(objRegisterModel.UserName,AuthenticationManager))
            {
                ModelState.AddModelError("", "User already exists");
                return View(objRegisterModel);
            }

            var result = await registerbusiness.RegisterUser(objRegisterModel, AuthenticationManager);

            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", result.ToString());
            }

            return View(objRegisterModel);
        }
    }
}