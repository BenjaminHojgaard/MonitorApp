using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitorApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string HOT_Id { get; set; }
        public string HOT_MacAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public object HOT_Data { get; set; }
        public DateTime DateCreated { get; set; }
    }
}