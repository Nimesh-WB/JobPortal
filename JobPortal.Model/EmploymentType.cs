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
    [Table("EmploymentTypes")]
    [Index(nameof(EmploymentTypeName), IsUnique = true)]
    [Index(nameof(EmploymentTypeCode), IsUnique = true)]
    public class EmploymentType : BaseEntity
    {
        [Required(ErrorMessage = "Employment Type Name is Required"), MaxLength(50)]
        public string EmploymentTypeName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string EmploymentTypeCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
