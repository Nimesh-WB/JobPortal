using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class CityDto
    {
    }

    public record CreateCityDto(
        [Required(ErrorMessage = "City Name is required"), MaxLength(50)] string CityName,
        long CreatedBy,
        [MaxLength(10)] string CityCode = ""
        );

    public record UpdateCityDto(
        [MaxLength(50)] string CityName,
        long UpdatedBy,
        bool IsActive,
        [MaxLength(10)] string CityCode = ""
        );

    public record GetCityDto(
        long Id, 
        string CityName, 
        string CityCode, 
        bool IsActive
        );
}
