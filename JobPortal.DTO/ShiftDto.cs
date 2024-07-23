using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class ShiftDto
    {
    }

    public record CreateShiftDto(
        [Required(ErrorMessage = "Shift Name is required"), MaxLength(50)] string ShiftName,
        long CreatedBy,
        [MaxLength(10)] string ShiftCode = ""
        );

    public record UpdateShiftDto( 
        [MaxLength(50)] string ShiftName, 
        bool IsActive,
        long UpdatedBy,
        [MaxLength(10)] string ShiftCode = ""
        );

    public record GetShiftDto(
        long Id, 
        string ShiftName, 
        string ShiftCode, 
        bool IsActive
        );
}
