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
    [Table("Designations")]
    [Index(nameof(DesignationName), IsUnique = true)]
    [Index(nameof(DesignationCode), IsUnique = true)]
    public class Designation : BaseEntity
    {
        [Required(ErrorMessage = "Designation Name is Required!"), MaxLength(50)]
        public string DesignationName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string DesignationCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
