using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class EmploymentTypeDto
    {
    }

    public record CreateEmploymentTypeDto(
        [Required(ErrorMessage = "EmploymentTypeName is required"), MaxLength(50)] string EmploymentTypeName,
        long CreatedBy,
        [MaxLength(10)] string EmploymentTypeCode = ""
        );

    public record UpdateEmploymentTypeDto(
        [MaxLength(50)] string EmploymentTypeName,
        long UpdatedBy,
        bool IsActive,
        [MaxLength(10)] string EmploymentTypeCode = ""
        );

    public record GetEmploymentTypeDto(
        long Id,
        string EmploymentTypeName,
        string EmploymentTypeCode,
        bool IsActive
        );
}
