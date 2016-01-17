using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BwareAdmin.Models;

namespace BwareAdmin.Areas.Admin.Adapter.Interface
{
    interface IUserAdapter
    {
        IEnumerable<UserViewModel> getAllUsers();
        UserViewModel getUserRoles(String id);
    }
}
