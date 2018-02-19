using FoursquareApp.Contracts;
using FoursquareApp.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareApp.Service
{
    public class FoursquareAppService : IFoursquareAppService
    {
        private const string foursquareApiUrl = "https://api.foursquare.com/v2/venues/";
        private const string clientID = "HU1PPVWOUZJ2D2EMHYPYGEATR5G5DB4J5ECIWZVJK2WJMN42";
        private const string clientSecret = "JH0QGBSNI4HEPHYTCZLODYCL1ESEDJMBTF1YTCJZL5KP4DD3";
        private string clientInfo = "client_id=" + clientID + "&client_secret=" + clientSecret;
        private string dateInfo = "&v=" + String.Format("{0:yyyyMMdd}", DateTime.Now);

        public IList<Venue> GetVenues(string searchArea, string category)
        {
            string method = "search?";
            string searchAreaInfo = "&near=" + searchArea;
            string categoryInfo = "&categories=" + category;

            IList<Venue> venues = new List<Venue>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(foursquareApiUrl);
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = client.GetAsync(foursquareApiUrl + method + clientInfo + searchAreaInfo + categoryInfo + dateInfo).Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var jsonString = responseMessage.Content.ReadAsStringAsync().Result;
                        IRoot root = new RootVenues();
                        root = JsonConvert.DeserializeObject<RootVenues>(jsonString);
                        var response = (ResponseVenues)root.response;
                        venues = response.venues;
                    }
                }
            }
            catch (Exception e)
            {
                venues = new List<Venue>();
            }

            return venues;
        }

        public Venue GetVenue(string venueId)
        {
            string method = "?";
            Venue venue = new Venue();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(foursquareApiUrl);
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = client.GetAsync(foursquareApiUrl + venueId + method + clientInfo + dateInfo).Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var jsonString = responseMessage.Content.ReadAsStringAsync().Result;
                        IRoot root = new RootVenue();
                        root = JsonConvert.DeserializeObject<RootVenue>(jsonString);
                        var response = (ResponseVenue)root.response;
                        venue = response.venue;
                    }
                }
            }
            catch (Exception e)
            {
                venue = new Venue();
            }

            return venue;
        }

        public IList<Item> GetTips(string venueId)
        {
            string method = "/tips?";
            IList<Item> tips = new List<Item>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(foursquareApiUrl);
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = client.GetAsync(foursquareApiUrl + venueId + method + clientInfo + dateInfo).Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var jsonString = responseMessage.Content.ReadAsStringAsync().Result;
                        IRoot root = new RootTips();
                        root = JsonConvert.DeserializeObject<RootTips>(jsonString);
                        var response = (ResponseTips)root.response;
                        tips = response.tips.items;
                    }
                }
            }
            catch (Exception e)
            {
                tips = new List<Item>();
            }

            return tips;
        }

        public IList<PhotoItem> GetPhotos(string venueId)
        {
            string method = "/photos?";
            IList<PhotoItem> photos = new List<PhotoItem>();
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(foursquareApiUrl);
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = client.GetAsync(foursquareApiUrl + venueId + method + clientInfo + dateInfo).Result;
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var jsonString = responseMessage.Content.ReadAsStringAsync().Result;
                        IRoot root = new RootPhotos();
                        root = JsonConvert.DeserializeObject<RootPhotos>(jsonString);
                        var response = (ResponsePhotos)root.response;
                        photos = response.photos.items;
                    }
                }
            }
            catch (Exception e)
            {
                photos = new List<PhotoItem>();
            }

            return photos;
        }
    }
}
