using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BwareAdmin.Models
{
    public class RoleViewModel
    { 
        public String CurrentName { get; set; }

        [Display(Name = "Name")]
        public String NewName { get; set; }

    }
}