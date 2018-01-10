using CodingExercise.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingExercise.Models.ViewModels;

namespace CodingExercise.Business.Logic
{
    class HotelLogic : IHotelLogic
    {
        public List<Hotel> GetHotelList(ISearchCriteria searchCriteria)
        {
            //call expedia api
            throw new NotImplementedException();
        }
    }
}
