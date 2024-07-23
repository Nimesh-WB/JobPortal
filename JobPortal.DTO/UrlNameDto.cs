using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class UrlNameDto
    {
        public record CreateUrlNameDto(
            [Required(ErrorMessage = "URL Name is required"), MaxLength(50)] string UrlName,
            long CreatedBy,
            [MaxLength(10)] string UrlCode = ""
        );
        public record GetUrlNameDto(
            long Id,
            string UrlName,
            string UrlCode,
            bool IsActive
        );
        public record UpdateUrlNameDto(
            [MaxLength(50)] string UrlName,
            bool IsActive,
            long UpdatedBy,
            [MaxLength(10)] string UrlCode = ""
        );
    }
}
