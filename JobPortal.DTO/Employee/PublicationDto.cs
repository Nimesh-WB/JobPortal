using System;
using System.ComponentModel.DataAnnotations;

namespace JobPortal.Data
{
    public class PublicationDto
    {
    }

    public record CreatePublicationDto(
        [Required(ErrorMessage = "Publication Title is required"), MaxLength(100)] string PublicationTitle,
        [Required(ErrorMessage = "Publisher Name is required"), MaxLength(100)] string PublisherName,
        [Required(ErrorMessage = "Publication Date is required")] DateTime PublishDate,
        string PublicationURL,
        string Description,
        [Required(ErrorMessage = "UserId is required")] long UserId,
        long CreatedBy
        );

    public record UpdatePublicationDto(
        [MaxLength(100)] string PublicationTitle,
        [MaxLength(100)] string PublisherName,
        DateTime PublishDate,
        string PublicationURL,
        string Description,
        long UserId,
        bool IsActive,
        long UpdatedBy
        );

    public record GetPublicationDto(
        long Id,
        string PublicationTitle,
        string PublisherName,
        DateTime PublishDate,
        string PublicationURL,
        string Email,
        string Description,
        bool IsActive
        );
}
