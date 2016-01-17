using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BwareAdmin.Models;
using Bware.Data;
using BwareAdmin.Areas.Admin.Adapter.Interface;


namespace BwareAdmin.Areas.Admin.Adapter.Data
{
    public class UserAdapter : IUserAdapter
    {
        public IEnumerable<UserViewModel> getAllUsers()
        {
            var db = new Bware.Data.Model.BwareContext();

            return db.AspNetUsers.Select(u => new UserViewModel { UserName = u.UserName, UserId = u.Id }).ToList();
        }

        public UserViewModel getUserRoles(string id)
        {
            var db = new Bware.Data.Model.BwareContext();
            var roleModel = new UserViewModel();
            var roleList = new List<String>();

            var roles = db.AspNetUsers.Where(U => U.Id == id).FirstOrDefault().AspNetRoles.ToList();

            foreach (var role in roles)
            {
                roleList.Add(role.Name);
            }

            roleModel.Roles = roleList;

            return roleModel;
        }
    }
}
