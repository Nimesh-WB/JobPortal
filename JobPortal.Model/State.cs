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
    [Table("States")]
    [Index(nameof(StateName), IsUnique = true)]
    [Index(nameof(StateCode), IsUnique = true)]
    public class State : BaseEntity
    {
        [Required(ErrorMessage ="State Name is Required!"), MaxLength(50)]
        public string StateName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string StateCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
