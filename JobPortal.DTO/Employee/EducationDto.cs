using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class EducationDto
    {
        public record CreateEducationDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "Qualification Id is Required")] long QualificationId,
            [Required(ErrorMessage = "Institute Name is required"), MaxLength(100)] string InstituteName,
            [Required(ErrorMessage = "Board or University Name is required"), MaxLength(100)] string BoardOrUniversityName,
            [Required(ErrorMessage = "Degree Name is required"), MaxLength(100)] string DegreeName,
            DateTime StartDate,
            DateTime EndDate,
            float GradeOrPercentage,
            long CreatedBy
        );

        public record GetEducationDto(
            long Id,
            string Email,
            string QualificationName,
            string InstituteName,
            string BoardOrUniversityName,
            string DegreeName,
            DateTime StartDate,
            DateTime EndDate,
            float GradeOrPercentage
        );

        public record UpdateEducationDto(
            long UserId,
            long QualificationId,
            [MaxLength(100)] string InstituteName,
            [MaxLength(100)] string BoardOrUniversityName,
            [MaxLength(100)] string DegreeName,
            DateTime StartDate,
            DateTime EndDate,
            float GradeOrPercentage,
            long UpdatedBy
        );
    }
}
