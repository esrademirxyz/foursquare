using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class ResponsePhotos : IResponse
    {
       public Photo photos { get; set; }
        public ResponsePhotos()
        {
            photos = new Photo();
        }
    }
}
