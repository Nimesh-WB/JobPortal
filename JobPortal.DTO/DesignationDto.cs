using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class DesignationDto
    {
    }

    public record CreateDesignationDto(
        [Required(ErrorMessage = "Designation Name is required"), MaxLength(50)] string DesignationName,
        long CreatedBy,
        [MaxLength(10)] string DesignationCode = ""
        );
    public record UpdateDesignationDto(
        [MaxLength(50)] string DesignationName,
        bool IsActive,
        long UpdatedBy,
        [MaxLength(10)] string DesignationCode = ""
        );
    public record GetDesignationDto(
        long Id, 
        string DesignationName, 
        string DesignationCode, 
        bool IsActive
        );
}
