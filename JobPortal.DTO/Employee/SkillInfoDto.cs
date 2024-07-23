using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class SkillInfoDto
    {
        public record CreateSkillInfoDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "Skill Id is Required")] long SkillId,
            [Required(ErrorMessage = "Skill Experience is Required")] int SkillExperience,
            long CreatedBy
        );
        public record GetSkillInfoDto(
            long Id,
            string Email,
            string SkillName,
            int SkillExperience
        );
        public record UpdateSkillInfoDto(
            long UserId,
            long SkillId,
            int SkillExperience,
            long UpdatedBy
        );
    }
}
