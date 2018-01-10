using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodingExercise.Areas.Hotel.Controllers
{
    public class HotelController : Controller
    {
        [HttpGet]
        // GET: Hotel/Hotel
        public ActionResult Index()
        {
            return View();
        }
    }
}