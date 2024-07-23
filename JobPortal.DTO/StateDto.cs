using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class StateDto
    {
    }

    public record CreateStateDto(
        [Required(ErrorMessage = "State Name is required"), MaxLength(50)] string StateName, 
        long CreatedBy,
        [MaxLength(10)] string StateCode = ""
        );

    public record UpdateStateDto(
        [MaxLength(50)] string StateName,
        long UpdatedBy,
        bool IsActive, 
        [MaxLength(10)] string StateCode = ""
        );

    public record GetStateDto(
        long Id, 
        string StateName, 
        string StateCode, 
        bool IsActive
        );
}
