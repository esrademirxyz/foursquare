using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class RootVenue:IRoot
    {
        public Meta meta { get; set; }
        public IResponse response { get; set; }
        public RootVenue()
        {
            response = new ResponseVenue();
        }
    }
}
