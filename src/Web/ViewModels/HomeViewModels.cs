using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShaBoo.Entities;

namespace ShaBoo.Web.ViewModels
{
    public class HomeViewModels
    {
        public class RoleViewModel
        {
            public IEnumerable<Role> Roles { get; set; }
        }
    }
}