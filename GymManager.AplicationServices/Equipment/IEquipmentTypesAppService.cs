using GymManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Equipment
{
    public interface IEquipmentTypesAppService
    {
        Task<List<EquipmentType>> GetEquipmentTypesAsync();

        Task<int> AddMemberAsync(EquipmentType equipmentType);

        Task DeleteEquipmentTypeAsync(int equimpentTypeId);

        Task<EquipmentType> GetEquipmentTypeByIdAsync(int equipmentTypeId);

        Task EditEquipmentTypeAsync(EquipmentType equipmentType);
    }
}
