using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Data
{
    public class TrainLineDto
    {
    }

    public record CreateTrainLineDto(
        [Required(ErrorMessage = "TrainLineName is required"), MaxLength(50)] string TrainLineName,
        long CreatedBy,
        [MaxLength(10)] string TrainLineCode = ""
        );
    public record UpdateTrainLineDto(
        [MaxLength(50)] string TrainLineName,
        long UpdatedBy,
        bool IsActive,
        [MaxLength(10)] string TrainLineCode = ""
        );
    public record GetTrainLineDto(
        long Id, 
        string TrainLineName, 
        string TrainLineCode, 
        bool IsActive
        );
}
