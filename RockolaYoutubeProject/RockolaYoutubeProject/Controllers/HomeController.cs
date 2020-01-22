using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace RockolaYoutubeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult SearchList(string palabra)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyDLl03D6wFfhOaeqUIJ5wR2mDhXNckgAas",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = palabra; // Replace with your search term.
            searchListRequest.MaxResults = 5;

            var searchListResponse = searchListRequest.Execute();

            return PartialView("Search",searchListResponse.Items);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}