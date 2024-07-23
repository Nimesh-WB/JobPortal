using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class PersonalInfoDto
    {
        public record CreatePersonalInfoDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "Gender Id is Required")] long GenderId,
            string ProfilePic,
            [Required(ErrorMessage = "First Name is required"), MaxLength(50)] string FirstName,
            [Required(ErrorMessage = "Last Name is required"), MaxLength(50)] string LastName,
            long CreatedBy
        );

        public record GetPersonalInfoDto(
            long Id,
            string Email,
            string GenderName,
            string ProfilePic,
            string FirstName,
            string LastName
        );

        public record UpdatePersonalInfoDto(
            long UserId,
            long GenderId,
            string ProfilePic,
            [MaxLength(50)] string FirstName,
            [MaxLength(50)] string LastName,
            long UpdatedBy
        );
    }
}
