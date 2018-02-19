using FoursquareApp.Contracts;
using FoursquareApp.Domain;
using FoursquareApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoursquareApp.Controllers
{
    public class HomeController : Controller
    {
        IFoursquareAppService foursquareAppService;

        public HomeController()
        {
            foursquareAppService = new FoursquareAppService();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetVenues(string searchArea,string categoryId)
        {
            IList<Venue> venues = new List<Venue>();
            try
            {
                venues = foursquareAppService.GetVenues(searchArea, categoryId);

            }
            catch
            {
                venues = new List<Venue>();
            }
            return View(venues);
        }

        public ActionResult GetVenue(string venueId)
        {
            Venue venue = new Venue();
            try
            {
                venue = foursquareAppService.GetVenue(venueId);

            }
            catch
            {
                venue = new Venue();
            }
            return View(venue);
        }

        public PartialViewResult _PartialVenue(string venueId)
        {
            Venue venue = new Venue();
            try
            {
                venue = foursquareAppService.GetVenue(venueId);

            }
            catch
            {
                venue = new Venue();
            }
            return PartialView(venue);
        }

        public PartialViewResult _PartialTips(string venueId)
        {
            IList<Item> tips = new List<Item>();
            try
            {
                tips = foursquareAppService.GetTips(venueId);

            }
            catch
            {
                tips = new List<Item>();
            }
            return PartialView(tips);
        }

        public PartialViewResult _PartialPhotos(string venueId)
        {
            IList<PhotoItem> photos = new List<PhotoItem>();
            try
            {
                photos = foursquareAppService.GetPhotos(venueId);

            }
            catch
            {
                photos = new List<PhotoItem>();
            }
            return PartialView(photos);
        }
    }
}