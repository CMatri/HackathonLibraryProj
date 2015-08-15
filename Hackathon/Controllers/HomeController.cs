using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hackathon.Models;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetPictureByCoords(CoordsRequestModel request)
        {
            ResponseData[] data = new ResponseData[2];

            data[0] = new ResponseData();
            data[0].url = "/7/471/Davis_1.21_Elks_Carnival_High_Wire_Act_.jpg";
            data[0].date = "Circa 1895";
            data[0].id = "Davis1.21";
            data[0].publisher = "Alicia Sell";
            data[0].description = "Elks Carnival High Wire Act about 1895...";
            data[0].subject = "carnival; Rorer Hall; St. Mark's Lutheran Church; Downtown";
            data[0].title = "Davis 1.21 Elks Carnival High Wire";
            data[0].spatial_coverage = new[] { "Downtown", "37.272286", "-79.944412" };
            data[0].tags = new[] { "carnival", "Downtown", "Rorer Hall", "St. Mark's Lutheran Church" };

            data[1] = new ResponseData();
            data[0].url = "/7/471/Davis_1.21_Elks_Carnival_High_Wire_Act_.jpg";
            data[1].date = "1960s";
            data[1].id = "Davis1.25";
            data[1].publisher = "Alicia Sell";
            data[1].description = "Looking NE across city from 1st & Day Ave.";
            data[1].subject = "Patrick Henry Hotel; Downtown";
            data[1].title = "Davis 1.25 Looking NE from 1st & Day";
            data[1].spatial_coverage = new[] { "37.268064", "-79.942552" };
            data[1].tags = new[] { "Downtown", "Patrick Henry Hotel" };

            CoordsResponseModel response = new CoordsResponseModel(data);

            JsonResult result = new JsonResult();
            result.Data = response;

            return result;
        }

        //public JsonResult GetPictureByKeyword()
        //{

        //}
    }
}
