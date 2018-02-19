using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public class ResponseTips : IResponse
    {
        public Tip tips { get; set; }
        public ResponseTips()
        {
            tips = new Tip();
        }
    }
}
