using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class QualificationDto
    {
    }

    public record CreateQualificationDto(
        [Required(ErrorMessage = "Qualification Name is required"), MaxLength(50)] string QualificationName,
        long CreatedBy,
        [MaxLength(10)] string QualificationCode = ""
        );

    public record UpdateQualificationDto(
        [MaxLength(50)] string QualificationName,
        bool IsActive,
        long UpdatedBy,
        [MaxLength(10)] string QualificationCode = ""
        );

    public record GetQualificationDto(
        long Id,
        string QualificationName,
        string QualificationCode,
        bool IsActive
        );
}
