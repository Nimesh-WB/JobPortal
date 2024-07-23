using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class LanguageDto
    {
        public record CreateLanguageDto(
            [Required(ErrorMessage = "Language Name is required"), MaxLength(50)] string LanguageName,
            long CreatedBy,
        [MaxLength(10)] string LanguageCode = ""
        );

        public record GetLanguageDto(
            long Id,
            [MaxLength(50)] string LanguageName,
            [MaxLength(10)] string LanguageCode,
            bool IsActive
        );

        public record UpdateLanguageDto(
            string LanguageName,
            bool IsActive,
            long UpdatedBy,
            string LanguageCode = ""
        );
    }
}
