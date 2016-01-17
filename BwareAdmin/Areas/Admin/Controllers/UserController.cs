using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BwareAdmin.Areas.Admin.Adapter;

namespace BwareAdmin.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        Adapter.Interface.IUserAdapter _adapter;

        public UserController()
        {
            _adapter = new Adapter.Data.UserAdapter();
        }

        // GET: Admin/User
        public ActionResult Index()
        {
            var result = _adapter.getAllUsers();
            return View(result);
        }

        public ActionResult Role(String id)
        {
            var result = _adapter.getUserRoles(id);
            return View(result);
        }


    }
}
