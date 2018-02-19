using FoursquareApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoursquareApp.Contracts
{
    public interface IFoursquareAppService
    {
        IList<Venue> GetVenues(string searchArea, string categoryId);
        Venue GetVenue(string venueId);
        IList<Item> GetTips(string venueId);
        IList<PhotoItem> GetPhotos(string venueId);
    }
}
