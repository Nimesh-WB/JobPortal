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
    [Table("TrainLines")]
    [Index(nameof(TrainLineName), IsUnique = true)]
    [Index(nameof(TrainLineCode), IsUnique = true)]
    public class TrainLine : BaseEntity
    {
        [Required(ErrorMessage ="Train Line Name is required."), MaxLength(50)]
        public string TrainLineName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string TrainLineCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
