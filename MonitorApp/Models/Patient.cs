using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitorApp.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PatientID { get; set; }
        public string HOT_MacAddress { get; set; }
        public string FirstName { get; set; }
        public DateTime LastMeasurement { get; set; }
        public object HOT_Data { get; set; }
        public int CreatedBy { get; set; }

    }
}