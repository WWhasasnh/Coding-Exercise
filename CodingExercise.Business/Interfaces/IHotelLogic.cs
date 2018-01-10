using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise.Business.Interfaces
{
    public interface IHotelLogic
    {
        List<CodingExercise.Models.ViewModels.Hotel> GetHotelList(ISearchCriteria searchCriteria);
    }
}
