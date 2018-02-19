using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class RootPhotos : IRoot
    {
        public Meta meta { get; set; }
        public IResponse response { get; set; }

        public RootPhotos()
        {
            response = new ResponsePhotos();
        }
    }
}
