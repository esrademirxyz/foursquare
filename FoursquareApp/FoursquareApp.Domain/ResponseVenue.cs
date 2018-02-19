using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class ResponseVenue : IResponse
    {
        public Venue venue { get; set; }
        public ResponseVenue()
        {
            venue = new Venue();
        }
    }
}
