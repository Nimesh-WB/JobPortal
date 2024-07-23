using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.API.Migrations
{
    /// <inheritdoc />
    public partial class updatedContactPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyInfos_JobPosts_JobPostId",
                table: "ApplyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplyInfos_Users_UserId",
                table: "ApplyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CertificationInfos_Users_UserId",
                table: "CertificationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_Users_UserId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPersons_CompanyInfos_CompanyInfoId",
                table: "ContactPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Qualifications_QualificationId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyInfos_CompanyInfoId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Designations_DesignationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_EmploymentTypes_EmploymentTypeId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Languages_LanguageId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Qualifications_QualificationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Recruiters_RecruiterId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Shifts_ShiftId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Skills_SkillId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_TrainLines_TrainLineId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_WorkTypes_WorkTypeId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageInfos_Languages_LanguageId",
                table: "LanguageInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageInfos_Users_UserId",
                table: "LanguageInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Cities_CityId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Countries_CountryId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_States_StateId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_TrainLines_TrainLineId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Users_UserId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Genders_GenderId",
                table: "PersonalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Users_UserId",
                table: "PersonalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Users_UserId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Recruiters_CompanyInfos_CompanyInfoId",
                table: "Recruiters");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillInfo_Skills_SkillId",
                table: "SkillInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillInfo_Users_UserId",
                table: "SkillInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UrlInfos_UrlNames_UrlNameId",
                table: "UrlInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UrlInfos_Users_UserId",
                table: "UrlInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_Designations_DesignationId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_EmploymentTypes_EmploymentTypeId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_Users_UserId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_WorkTypes_WorkTypeId",
                table: "WorkExperienceInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyInfos_JobPosts_JobPostId",
                table: "ApplyInfos",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyInfos_Users_UserId",
                table: "ApplyInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CertificationInfos_Users_UserId",
                table: "CertificationInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_Users_UserId",
                table: "CompanyInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPersons_CompanyInfos_CompanyInfoId",
                table: "ContactPersons",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Qualifications_QualificationId",
                table: "Educations",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyInfos_CompanyInfoId",
                table: "JobPosts",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Designations_DesignationId",
                table: "JobPosts",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_EmploymentTypes_EmploymentTypeId",
                table: "JobPosts",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Languages_LanguageId",
                table: "JobPosts",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Qualifications_QualificationId",
                table: "JobPosts",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Recruiters_RecruiterId",
                table: "JobPosts",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Shifts_ShiftId",
                table: "JobPosts",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Skills_SkillId",
                table: "JobPosts",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_TrainLines_TrainLineId",
                table: "JobPosts",
                column: "TrainLineId",
                principalTable: "TrainLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_WorkTypes_WorkTypeId",
                table: "JobPosts",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageInfos_Languages_LanguageId",
                table: "LanguageInfos",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageInfos_Users_UserId",
                table: "LanguageInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Cities_CityId",
                table: "LocationInfo",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Countries_CountryId",
                table: "LocationInfo",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_States_StateId",
                table: "LocationInfo",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_TrainLines_TrainLineId",
                table: "LocationInfo",
                column: "TrainLineId",
                principalTable: "TrainLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Users_UserId",
                table: "LocationInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Genders_GenderId",
                table: "PersonalInfos",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Users_UserId",
                table: "PersonalInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Users_UserId",
                table: "Publications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiters_CompanyInfos_CompanyInfoId",
                table: "Recruiters",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillInfo_Skills_SkillId",
                table: "SkillInfo",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillInfo_Users_UserId",
                table: "SkillInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UrlInfos_UrlNames_UrlNameId",
                table: "UrlInfos",
                column: "UrlNameId",
                principalTable: "UrlNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UrlInfos_Users_UserId",
                table: "UrlInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_Designations_DesignationId",
                table: "WorkExperienceInfos",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_EmploymentTypes_EmploymentTypeId",
                table: "WorkExperienceInfos",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_Users_UserId",
                table: "WorkExperienceInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_WorkTypes_WorkTypeId",
                table: "WorkExperienceInfos",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyInfos_JobPosts_JobPostId",
                table: "ApplyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplyInfos_Users_UserId",
                table: "ApplyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CertificationInfos_Users_UserId",
                table: "CertificationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyInfos_Users_UserId",
                table: "CompanyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPersons_CompanyInfos_CompanyInfoId",
                table: "ContactPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Qualifications_QualificationId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_CompanyInfos_CompanyInfoId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Designations_DesignationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_EmploymentTypes_EmploymentTypeId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Languages_LanguageId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Qualifications_QualificationId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Recruiters_RecruiterId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Shifts_ShiftId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Skills_SkillId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_TrainLines_TrainLineId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_WorkTypes_WorkTypeId",
                table: "JobPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageInfos_Languages_LanguageId",
                table: "LanguageInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguageInfos_Users_UserId",
                table: "LanguageInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Cities_CityId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Countries_CountryId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_States_StateId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_TrainLines_TrainLineId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LocationInfo_Users_UserId",
                table: "LocationInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Genders_GenderId",
                table: "PersonalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_Users_UserId",
                table: "PersonalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Users_UserId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Recruiters_CompanyInfos_CompanyInfoId",
                table: "Recruiters");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillInfo_Skills_SkillId",
                table: "SkillInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillInfo_Users_UserId",
                table: "SkillInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_UrlInfos_UrlNames_UrlNameId",
                table: "UrlInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UrlInfos_Users_UserId",
                table: "UrlInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_Designations_DesignationId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_EmploymentTypes_EmploymentTypeId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_Users_UserId",
                table: "WorkExperienceInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceInfos_WorkTypes_WorkTypeId",
                table: "WorkExperienceInfos");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyInfos_JobPosts_JobPostId",
                table: "ApplyInfos",
                column: "JobPostId",
                principalTable: "JobPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyInfos_Users_UserId",
                table: "ApplyInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CertificationInfos_Users_UserId",
                table: "CertificationInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyInfos_Users_UserId",
                table: "CompanyInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPersons_CompanyInfos_CompanyInfoId",
                table: "ContactPersons",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Qualifications_QualificationId",
                table: "Educations",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_UserId",
                table: "Educations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_CompanyInfos_CompanyInfoId",
                table: "JobPosts",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Designations_DesignationId",
                table: "JobPosts",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_EmploymentTypes_EmploymentTypeId",
                table: "JobPosts",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Languages_LanguageId",
                table: "JobPosts",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Qualifications_QualificationId",
                table: "JobPosts",
                column: "QualificationId",
                principalTable: "Qualifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Recruiters_RecruiterId",
                table: "JobPosts",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Shifts_ShiftId",
                table: "JobPosts",
                column: "ShiftId",
                principalTable: "Shifts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Skills_SkillId",
                table: "JobPosts",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_TrainLines_TrainLineId",
                table: "JobPosts",
                column: "TrainLineId",
                principalTable: "TrainLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_WorkTypes_WorkTypeId",
                table: "JobPosts",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageInfos_Languages_LanguageId",
                table: "LanguageInfos",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguageInfos_Users_UserId",
                table: "LanguageInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Cities_CityId",
                table: "LocationInfo",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Countries_CountryId",
                table: "LocationInfo",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_States_StateId",
                table: "LocationInfo",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_TrainLines_TrainLineId",
                table: "LocationInfo",
                column: "TrainLineId",
                principalTable: "TrainLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocationInfo_Users_UserId",
                table: "LocationInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Genders_GenderId",
                table: "PersonalInfos",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_Users_UserId",
                table: "PersonalInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Users_UserId",
                table: "Publications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiters_CompanyInfos_CompanyInfoId",
                table: "Recruiters",
                column: "CompanyInfoId",
                principalTable: "CompanyInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillInfo_Skills_SkillId",
                table: "SkillInfo",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillInfo_Users_UserId",
                table: "SkillInfo",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UrlInfos_UrlNames_UrlNameId",
                table: "UrlInfos",
                column: "UrlNameId",
                principalTable: "UrlNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UrlInfos_Users_UserId",
                table: "UrlInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_Designations_DesignationId",
                table: "WorkExperienceInfos",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_EmploymentTypes_EmploymentTypeId",
                table: "WorkExperienceInfos",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_Users_UserId",
                table: "WorkExperienceInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceInfos_WorkTypes_WorkTypeId",
                table: "WorkExperienceInfos",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
