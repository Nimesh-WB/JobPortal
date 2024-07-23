using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class CertificationInfoDto
    {
        public record CreateCertificationInfoDto(
            [Required(ErrorMessage = "User Id is required")] long UserId,
            [Required(ErrorMessage = "Certificate Name is required"), MaxLength(100)] string CertficateName,
            [Required(ErrorMessage = "Organixation Name is required"), MaxLength(100)] string OrganisationName,
            [Required(ErrorMessage = "Issue Date is required")] DateTime IssueDate,
            DateTime ExpiryDate,
            string SkillAcquired,
            string CertificateURL,
            long CreatedBy
        );
        public record GetCertificationInfoDto(
            long Id,
            string Email,
            string CertficateName,
            string OrganisationName,
            DateTime IssueDate,
            DateTime ExpiryDate,
            string SkillAcquired,
            string CertificateURL
        );
        public record UpdateCertificationInfoDto(
            long UserId,
            [MaxLength(100)] string CertficateName,
            [MaxLength(100)] string OrganisationName,
            DateTime IssueDate,
            DateTime ExpiryDate,
            string SkillAcquired,
            string CertificateURL,
            long UpdatedBy
        );
    }
}
