using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitorApp.Models
{
    public class Request
    {
        [Key, Column(Order = 0)]
        public int SenderId { get; set; }
        [Key, Column(Order = 1)]
        public int ReceiverId { get; set; }
        public bool IsAccepted { get; set; }
    }
}