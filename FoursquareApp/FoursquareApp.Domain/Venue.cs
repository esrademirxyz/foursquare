using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public IList<Category> categories { get; set; }
        public Location location { get; set; }
        //public IList<Tip> tips { get; set; }
        public Venue()
        {
            categories = new List<Category>();
            location = new Location();
            //tips = new List<Tip>();
        }

    }
}
