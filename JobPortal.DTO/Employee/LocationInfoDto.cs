using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class LocationInfoDto
    {
        public record CreateLocationInfoDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "City Id is Required")] long CityId,
            [Required(ErrorMessage = "State Id is Required")] long StateId,
            [Required(ErrorMessage = "Country Id is Required")] long CountryId,
            [Required(ErrorMessage = "TrainLine Id is Required")] long TrainLineId,
            [Required(ErrorMessage = "Address Line 1 is Required"), MaxLength(250)] string AddressLine1,
            [MaxLength(250)] string AddressLine2,
            long ZipCode,
            long CreatedBy
        );
        public record GetLocationInfoDto(
            long Id,
            string Email,
            string City,
            string State,
            string Country,
            string TrainLine,
            string AddressLine1,
            string AddressLine2,
            long ZipCode
        );
        public record UpdateLocationInfoDto(
            long UserId,
            long CityId,
            long StateId,
            long CountryId,
            long TrainLineId,
            [MaxLength(250)] string AddressLine1,
            [MaxLength(250)] string AddressLine2,
            long ZipCode,
            long UpdatedBy
        );
    }
}
