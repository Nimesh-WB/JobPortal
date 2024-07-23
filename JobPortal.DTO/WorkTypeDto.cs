using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO
{
    public class WorkTypeDto
    {
        public record CreateWorkTypeDto(
            [Required(ErrorMessage = "Work-Type Name is required"), MaxLength(50)] string WorkTypeName,
            long CreatedBy,
            [MaxLength(10)] string WorkTypeCode = ""
        );
        public record GetWorkTypeDto(
            long Id,
            string WorkTypeName,
            string WorkTypeCode,
            bool IsActive
        );
        public record UpdateWorkTypeDto(
            [MaxLength(50)] string WorkTypeName,
            bool IsActive,
            long UpdatedBy,
            [MaxLength(10)] string WorkTypeCode = ""
        );
    }
}
