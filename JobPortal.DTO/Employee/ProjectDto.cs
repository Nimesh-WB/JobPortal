﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.DTO.Employee
{
    public class ProjectDto
    {
        public record CreateProjectDto(
            [Required(ErrorMessage = "User Id is Required")] long UserId,
            [Required(ErrorMessage = "Project Title is required"), MaxLength(50)] string ProjectTitle,
            string ProjectDescription,
            [Required(ErrorMessage = "Skill is required")] string Skills,
            DateTime ExpiryDate,
            string Contributor,
            string ProjectUrl,
            long CreatedBy
        );

        public record GetProjectDto(
            long Id,
            string Email,
            string ProjectTitle,
            string ProjectDescription,
            string Skills,
            DateTime ExpiryDate,
            string Contributor,
            string ProjectUrl
        );

        public record UpdateProjectDto(
            long UserId,
            [MaxLength(50)] string ProjectTitle,
            string ProjectDescription,
            string Skills,
            DateTime ExpiryDate,
            string Contributor,
            string ProjectUrl,
            long UpdatedBy
        );
    }
}
