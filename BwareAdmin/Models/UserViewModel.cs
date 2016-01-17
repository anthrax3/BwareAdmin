using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BwareAdmin.Models
{
    public class UserViewModel
    {
        public String UserName { get; set; }
        public String UserId { get; set; }
        public List<String> Roles { get; set; }

    }
}
