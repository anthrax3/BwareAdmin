using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BwareAdmin.Models;

namespace BwareAdmin.Areas.Admin.Adapter.Interface
{
    interface IRoleAdapter
    {
        IEnumerable<RoleViewModel> getRoleViewModelList();
        bool SaveRole(RoleViewModel model);
        RoleViewModel getRoleFromId(string id);
        bool removeRole(RoleViewModel model);

    }
}
