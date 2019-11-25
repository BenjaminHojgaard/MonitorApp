﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitorApp.Models
{
    public class MonitorUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Country { get; set; }
        public DateTime DateCreated { get; set; }
        public Role[] UserRoles { get; set; }
    }
}