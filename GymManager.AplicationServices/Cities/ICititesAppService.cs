using GymManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Cities
{
    public interface ICititesAppService
    {
        Task<List<City>> GetCitiesAsync();

        Task<int> AddCitytAsync(City city);

        Task DeleteCityAsync(int cityId);

        Task<City> GetCityByIdAsync(int cityId);

        Task EditCityAsync(City city);
    }
}
