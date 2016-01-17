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

            return db.AspNetUsers.Select(u => new UserViewModel { UserName = u.UserName }).ToList();
        }
    }
}
