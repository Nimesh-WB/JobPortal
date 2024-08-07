﻿using JobPortal.Model.Company;
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
    [Table("WorkTypes")]
    [Index(nameof(WorkTypeName), IsUnique = true)]
    [Index(nameof(WorkTypeCode), IsUnique = true)]
    public class WorkType : BaseEntity
    {
        [Required(ErrorMessage = "Work Type Name is Required"), MaxLength(50)]
        public string WorkTypeName { get; set; } = string.Empty;

        [MaxLength(10)]
        public string WorkTypeCode { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

    }
}
