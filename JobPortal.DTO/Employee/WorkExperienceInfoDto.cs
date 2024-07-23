using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class WorkExperienceInfoDto
    {
        public record CreateWorkExperienceInfoDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "Work-Type Id is Required")] long WorkTypeId,
            [Required(ErrorMessage = "Employment-Type Id is Required")] long EmploymentTypeId,
            [Required(ErrorMessage = "Designation Id is Required")] long DesignationId,
            [Required(ErrorMessage = "Company Name is Required"), MaxLength(100)] string CompanyName,
            DateTime StartDate,
            DateTime EndDate,
            string SkillsUsed,
            long CreatedBy
        );
        public record GetWorkExperienceInfoDto(
            long Id,
            string Email,
            string WorkType,
            string EmploymentType,
            string Designation,
            string CompanyName,
            DateTime StartDate,
            DateTime EndDate,
            string SkillsUsed
        );
        public record UpdateWorkExperienceInfoDto(
            long UserId,
            long WorkTypeId,
            long EmploymentTypeId,
            long DesignationId,
            [MaxLength(100)] string CompanyName,
            DateTime StartDate,
            DateTime EndDate,
            string SkillsUsed,
            long UpdatedBy
        );
    }
}
