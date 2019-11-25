using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MonitorApp.Utility
{
    public class CustomRoles : AuthorizeAttribute
    {
        public CustomRoles()
        {
            Roles = "SuperAdmin";
        }
    }
}