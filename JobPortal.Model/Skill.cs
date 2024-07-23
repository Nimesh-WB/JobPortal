using JobPortal.Model.Company;
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
    [Table("Skills")]
    [Index(nameof(SkillName), IsUnique = true)]
    [Index(nameof(SkillCode), IsUnique = true)]
    public class Skill : BaseEntity
    {
        [Required(ErrorMessage = "Skill Name is Required"), MaxLength(50)]
        public string SkillName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string SkillCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
