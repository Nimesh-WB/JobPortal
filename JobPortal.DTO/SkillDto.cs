using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class SkillDto
    {
    }

    public record CreateSkillDto(
        [Required(ErrorMessage = "Skill Name is required"), MaxLength(50)] string SkillName,
        long CreatedBy,
        [MaxLength(10)] string SkillCode = ""
        );

    public record UpdateSkillDto(
        [MaxLength(50)] string SkillName,
        long UpdatedBy,
        bool IsActive,
        [MaxLength(10)] string SkillCode = ""
        );

    public record GetSkillDto(
        long Id,
        string SkillName,
        string SkillCode,
        bool IsActive
        );
}
