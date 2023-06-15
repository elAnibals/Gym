using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Entities
{
    public class ProductSale
    {

        [Key]
        public int Id { get; set; }

        public MesureType MesureType { get; set; }
        public Sale Sale { get; set; }

        
    }
}
