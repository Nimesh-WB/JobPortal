using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class CountryDto
    {
    }

    public record CreateCountryDto(
        [Required(ErrorMessage = "CountryName is required")] string CountryName,
        long CreatedBy,
        [MaxLength(10)] string CountryCode = ""
        );

    public record UpdateCountryDto( 
        [MaxLength(50)] string CountryName, 
        bool IsActive,
        long UpdatedBy,
        [MaxLength(10)] string CountryCode = ""
        );

    public record GetCountryDto(long Id, 
        string CountryName, 
        string CountryCode, 
        bool IsActive
        );
}
