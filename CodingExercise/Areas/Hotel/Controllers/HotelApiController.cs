using CodingExercise.Areas.Hotel.Dtos;
using CodingExercise.Areas.Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodingExercise.Areas.Hotel.Controllers
{
    public class HotelApiController : ApiController
    {
        [HttpPost]
        // POST api/<controller>
        public List<HotelViewModel> HotelList(HotelDto value)
        {
            if (ModelState.IsValid)
            {

            }

            //call CodingExercise.Mapping
            //call CodingExercise.Business

            return new List<HotelViewModel>();
        }

    }
}