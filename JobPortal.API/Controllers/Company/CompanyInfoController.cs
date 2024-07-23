﻿using JobPortal.DTO.Company;
using JobPortal.IServices;
using JobPortal.IServices.Company;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static JobPortal.DTO.Company.CompanyInfoDto;

namespace JobPortal.API.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfoController : ControllerBase
    {
        private readonly ICompanyInfoServices _companyInfoServices;

        public CompanyInfoController(ICompanyInfoServices companyInfoServices)
        {
            _companyInfoServices = companyInfoServices;
        }

        // GET: api/<CompanyInfoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCompanyInfoDto>>> Get()
        {
            try
            {
                var companyInfos = await _companyInfoServices.GetAllCompaniesAsync();
                return Ok(companyInfos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<CompanyInfoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCompanyInfoDto>> Get(long id)
        {
            try
            {
                var companyInfo = await _companyInfoServices.GetCompanyInfoByIdAsync(id);
                return Ok(companyInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<CompanyInfoController>/company/5
        [HttpGet("company/{companyInfoId}")]
        public async Task<ActionResult<GetCompanyInfoDto>> GetCompanyInfoByUserId(long companyInfoId)
        {
            try
            {
                var companyInfo = await _companyInfoServices.GetCompanyInfoByUserIdAsync(companyInfoId);
                return Ok(companyInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<CompanyInfoController>
        [HttpPost]
        public async Task<ActionResult<GetCompanyInfoDto>> Post([FromBody] CreateCompanyInfoDto companyInfoDto)
        {
            try
            {
                var createdCompanyInfo = await _companyInfoServices.CreateCompanyInfoAsync(companyInfoDto);
                return CreatedAtAction(nameof(Get), new { id = createdCompanyInfo.Id }, createdCompanyInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<CompanyInfoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<GetCompanyInfoDto>> Put(long id, [FromBody] UpdateCompanyInfoDto companyInfoDto)
        {
            try
            {
                var updatedCompanyInfo = await _companyInfoServices.UpdateCompanyInfoAsync(id, companyInfoDto);
                return Ok(updatedCompanyInfo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE api/<CompanyInfoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(long id)
        {
            try
            {
                var deleted = await _companyInfoServices.DeleteCompanyInfoAsync(id);
                return Ok(deleted);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
