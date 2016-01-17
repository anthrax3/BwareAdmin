using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bware.Data.Model;
using BwareAdmin.Models;

namespace BwareAdmin.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        Adapter.Interface.IRoleAdapter _adapter;

        public RoleController()
        {
            _adapter = new Adapter.Data.RoleAdapter();
        }

        // GET: Admin/Role
        public ActionResult Index(String resultMessage = null)
        {
            ViewBag.Result = resultMessage; // display any result message if one has been passed
            var result = _adapter.getRoleViewModelList();
            return View(result);
        }


        // GET: Admin/Role/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Role/Create
        [HttpPost]
        public ActionResult Create(RoleViewModel roleModel)
        {
            if (!ModelState.IsValid || roleModel == null || roleModel.NewName == null ||roleModel.NewName == "")
            {
                return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} could not be created.", roleModel.NewName) });
            }

            try
            {
                if (_adapter.SaveRole(roleModel))
                {
                    return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} created.", roleModel.NewName) });

                }
                return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} could not be created.", roleModel.NewName) });

            }
            catch
            {
                return View();
            }
        }


        // GET: Admin/Role/Delete/5
        public ActionResult Delete(String id)
        {
            ViewBag.RoleName = id;
            var result = _adapter.getRoleFromId(id);

            if (result != null)  { return View(result); }

            // Not found
            return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} not found.", id) });
        }

        // POST: Admin/Role/Delete/5
        [HttpPost]
        public ActionResult Delete(RoleViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model == null || model.CurrentName == null || model.CurrentName == "")
            {
                return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} could not be deleted.", model.CurrentName) });
            }

            try
            {
                var result = _adapter.removeRole(model);

                if (result)
                {
                    return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} removed.", model.CurrentName) });
                }

                return RedirectToAction("Index", new { resultMessage = String.Format("Role {0} not found.", model.CurrentName) });
            }
            catch
            {
                return View(model);
            }
        }
    }
}
