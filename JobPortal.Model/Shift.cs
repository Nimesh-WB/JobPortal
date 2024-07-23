using JobPortal.Model.Company;
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
    [Table("Shifts")]
    [Index(nameof(ShiftName), IsUnique = true)]
    [Index(nameof(ShiftCode), IsUnique = true)]
    public class Shift : BaseEntity
    {
        [Required(ErrorMessage ="Shift Name is Required!"), MaxLength(50)]
        public string ShiftName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string ShiftCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
