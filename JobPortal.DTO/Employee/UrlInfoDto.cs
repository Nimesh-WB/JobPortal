﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class UrlInfoDto
    {
        public record CreateUrlInfoDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "UrlName Id is Required")] long UrlNameId,
            [Required(ErrorMessage = "Url is Required")] string UrlValue,
            long CreatedBy
        );
        public record GetUrlInfoDto(
            long Id,
            string Email,
            string UrlName,
            string UrlValue
        );
        public record UpdateUrlInfoDto(
            long UserId,
            long UrlNameId,
            string UrlValue,
            long UpdatedBy
        );
    }
}
