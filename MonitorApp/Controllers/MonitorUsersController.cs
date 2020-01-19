using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MonitorApp.Models;

namespace MonitorApp.Controllers
{
    public class MonitorUsersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public MonitorUsersController()
        {
        }

        // GET api/MonitorUsers
        [AllowAnonymous]
        public List<MonitorUser> Get()
        {
            var list = new List<MonitorUser>();
            foreach (var item in db.MonitorUsers)
            {
                list.Add(item);
            }
            return list;
        }

        // GET api/MonitorUsers/5
        [AllowAnonymous]
        public async Task<MonitorUser> Get(int id)
        {
            var result = await db.MonitorUsers.FirstOrDefaultAsync(userID => userID.Id == id);
            if (result == null)
                return null;

            return result;

        }

        // POST api/MonitorUsers
        [AllowAnonymous]
        public IHttpActionResult Post([FromBody] MonitorUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            user.DateCreated = DateTime.Now;

            db.MonitorUsers.Add(user);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);

        }

        // PUT api/MonitorUsers/5
        [AllowAnonymous]
        public async Task<IHttpActionResult> Put(int id, [FromBody] MonitorUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var result = await db.MonitorUsers.FirstOrDefaultAsync(userID => userID.Id == id);
            if(result == null)
            {
                return BadRequest("No object found with that ID.");
            }

            if (!(string.IsNullOrEmpty(user.Email)))
                result.Email = user.Email;

            if (!(string.IsNullOrEmpty(user.Country)))
                result.Country = user.Country;

            if (!(string.IsNullOrEmpty(user.Password)))
                result.Password = user.Password;

            db.SaveChanges();

            return StatusCode(HttpStatusCode.OK);
        }

    }
}