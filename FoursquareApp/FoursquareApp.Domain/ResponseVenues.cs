using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class ResponseVenues :IResponse
    {
        public IList<Venue> venues { get; set; }

        public ResponseVenues()
        {
            venues = new List<Venue>();
        }
    }
}
