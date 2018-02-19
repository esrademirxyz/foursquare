using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class Tip
    {
        public IList<Item> items { get; set; }
        public Tip()
        {
            items = new List<Item>();
        }
    }
}
