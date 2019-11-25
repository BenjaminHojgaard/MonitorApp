using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MonitorApp.Models;
using MonitorApp.Utility;

namespace MonitorApp.Controllers
{
    public class MonitorUsersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [CustomRoles(Roles = "SuperAdmin")]
        public IHttpActionResult Post([FromBody] MonitorUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.DateCreated = DateTime.Now;

            db.MonitorUsers.Add(user);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);

        }

    }
}