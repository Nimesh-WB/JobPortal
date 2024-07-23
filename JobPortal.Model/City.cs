using JobPortal.Model.Employee;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Model
{
    [Table("Cities")]
    [Index(nameof(CityName), IsUnique = true)]
    [Index(nameof(CityCode), IsUnique = true)]
    public class City : BaseEntity
    {
        [Required(ErrorMessage = "City Name is Required!"), MaxLength(50)]
        public string CityName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string CityCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
