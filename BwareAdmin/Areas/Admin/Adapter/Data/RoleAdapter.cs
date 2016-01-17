using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BwareAdmin.Models;
using Bware.Data.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;

namespace BwareAdmin.Areas.Admin.Adapter.Data
{
    public class RoleAdapter : Adapter.Interface.IRoleAdapter
    {
        public RoleViewModel getRoleFromId(string id)
        {
            var db = new BwareContext();
            var roleViewModel = new RoleViewModel();

            roleViewModel = db.AspNetRoles.Where(r => r.Name == id).Select(r => new RoleViewModel() { CurrentName = r.Name }).FirstOrDefault();
            return roleViewModel;
        }

        public IEnumerable<RoleViewModel> getRoleViewModelList()
        {
            var db = new BwareContext();
            var roleViewModelList = new List<RoleViewModel>();

            // get all role names and map to our view model with select
            roleViewModelList = db.AspNetRoles.Select(r => new RoleViewModel() { CurrentName = r.Name, NewName = "" }).ToList();
            return roleViewModelList;
        }

        public bool removeRole(RoleViewModel model)
        {
            if (model.CurrentName == null || model.CurrentName == "")
            {
                return false;
            }

            using (var identityContext = new IdentityDbContext())
            {
                try
                {
                    identityContext.Roles.Remove(identityContext.Roles.Where(r => r.Name == model.CurrentName).FirstOrDefault());
                    return identityContext.SaveChanges() == 1;
                }
                catch
                {
                    return false;
                }

            }
        }

        public bool SaveRole(RoleViewModel model)
        {
            if (model.NewName == null || model.NewName == "")
            {
                return false;
            }

            using (var identityContext = new IdentityDbContext())
            {
                try
                {
                    identityContext.Roles.AddOrUpdate(r => r.Name, new IdentityRole() { Name = model.NewName });
                    return identityContext.SaveChanges() == 1;
                }
                catch
                {
                    return false;
                }

            }
        }
    }
}