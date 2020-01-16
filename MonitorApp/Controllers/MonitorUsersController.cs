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

        private ApplicationUserManager _userManager;

        public MonitorUsersController()
        {
        }

        public MonitorUsersController(ApplicationUserManager userManager,
            ISecureDataFormat<AuthenticationTicket> accessTokenFormat)
        {
            UserManager = userManager;
            AccessTokenFormat = accessTokenFormat;
        }

        public ISecureDataFormat<AuthenticationTicket> AccessTokenFormat { get; private set; }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [AllowAnonymous]
        public async Task<IHttpActionResult> Post([FromBody] MonitorUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            var newuser = new ApplicationUser() { UserName = user.Email, Email = user.Email };

            IdentityResult result = await UserManager.CreateAsync(newuser, user.Password);

            if (!result.Succeeded)
            {
                return BadRequest("Something went wrong...");
            }

            user.DateCreated = DateTime.Now;

            db.MonitorUsers.Add(user);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);

        }

    }
}