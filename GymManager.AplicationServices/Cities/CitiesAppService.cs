using GymManager.Core.Entities;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Cities
{
    public class CitiesAppService : ICititesAppService
    {
        private readonly IRepository<int, City> _repository;

        public CitiesAppService(IRepository<int, City> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddCitytAsync(City city)
        {
            await _repository.AddAsync(city);
            return city.Id;
        }

        public async Task DeleteCityAsync(int cityId)
        {
            await _repository.DeleteAsync(cityId);
        }

        public async Task EditCityAsync(City city)
        {
            await _repository.UpdateAsync(city);
        }

        public async Task<List<City>> GetCitiesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<City> GetCityByIdAsync(int cityId)
        {
            return await _repository.GetAsync(cityId);
        }
    }
}
