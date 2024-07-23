using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class UserDto
    {
    }

    public record CreateUserDto(
        [Required(ErrorMessage = "Email is required"), MaxLength(100)] string Email, 
        [Required(ErrorMessage = "Password is required"), MaxLength(50)] string Password, 
        [Required(ErrorMessage = "Contact is required")] long Contact,
        long CreatedBy
        );

    public record UpdateUserDto(
        [MaxLength(100)] string Email, 
        [MaxLength(50)] string Password, 
        long Contact, 
        bool IsActive,
        long UpdatedBy
        );

    public record GetUserDto(
        long Id, 
        string Email,
        string Password, 
        long Contact,
        bool IsActive
        );
}
