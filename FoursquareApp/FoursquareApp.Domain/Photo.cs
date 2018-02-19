using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class Photo
    {
        public IList<PhotoItem> items { get; set; }
        public Photo()
        {
            items = new List<PhotoItem>();
        }
    }
}
