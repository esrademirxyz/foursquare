using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoursquareApp.Domain
{
    public class Location
    {
        public string lat { get; set; }
        public string lng { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string address { get; set; }
    }
}
