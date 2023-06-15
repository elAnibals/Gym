using GymManager.Core.Entities;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Equipment
{
    public class EquipmentTypesAppService : IEquipmentTypesAppService
    {
        private readonly EquipmentTypesRepository _equipmentTypesRepository;

        public EquipmentTypesAppService(EquipmentTypesRepository equipmentTypesRepository)
        {
            _equipmentTypesRepository = equipmentTypesRepository;
        }

        public async Task<int> AddMemberAsync(EquipmentType equipmentType)
        {
            await _equipmentTypesRepository.AddAsync(equipmentType);
            return equipmentType.Id;
        }

        public async Task DeleteEquipmentTypeAsync(int equimpentTypeId) => await _equipmentTypesRepository.DeleteAsync(equimpentTypeId);

        public async Task EditEquipmentTypeAsync(EquipmentType equipmentType) => await _equipmentTypesRepository.UpdateAsync(equipmentType);

        public async Task<EquipmentType> GetEquipmentTypeByIdAsync(int equipmentTypeId) => await _equipmentTypesRepository.GetAsync(equipmentTypeId);

        public async Task<List<EquipmentType>> GetEquipmentTypesAsync() => await _equipmentTypesRepository.GetAll().ToListAsync();
    }
}
