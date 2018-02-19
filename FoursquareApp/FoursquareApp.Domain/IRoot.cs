using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Domain
{
    public interface IRoot
    {
        Meta meta { get; set; }
        IResponse response { get; set; }
    }
}
