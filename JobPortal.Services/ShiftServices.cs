﻿using JobPortal.Data;
using JobPortal.IRepository;
using JobPortal.IServices;
using JobPortal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Services
{
    public class ShiftServices : IShiftServices
    {
        private readonly IShiftRepository _repository;
        public ShiftServices(IShiftRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetShiftDto> CreateShiftAsync(CreateShiftDto shiftDto)
        {
            try
            {
                var shift = await _repository.CreateAsync(new Shift()
                {
                    ShiftName = shiftDto.ShiftName,
                    ShiftCode = shiftDto.ShiftName.ToUpper().Substring(0, 1),
                    CreatedBy = shiftDto.CreatedBy,
                    UpdatedBy = shiftDto.CreatedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
                var createShiftObject = new GetShiftDto(shift.Id, shift.ShiftName, shift.ShiftCode, shift.IsActive);
                return createShiftObject;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("Cannot insert duplicate key row") == true ||
                    ex.InnerException?.Message.Contains("UNIQUE constraint failed") == true)
                {
                    throw new Exception("This Shift already exists.");
                }

                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteShiftAsync(long id)
        {
            try
            {
                var oldShift = await _repository.GetAsync(id);
                if (oldShift == null)
                {
                    throw new Exception($"Shift not found for id : {id}");
                }
                var deleteShiftObject = await _repository.DeleteAsync(oldShift);
                return deleteShiftObject;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<GetShiftDto>> GetAllShiftsAsync()
        {
            try
            {
                var shifts = await _repository.GetAllAsync();

                var getAllShiftObject = shifts.Select(shift => new GetShiftDto(shift.Id, shift.ShiftName, shift.ShiftCode, shift.IsActive));

                return getAllShiftObject;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetShiftDto> GetShiftByIdAsync(long id)
        {
            try
            {
                var shift = await _repository.GetAsync(id);
                if (shift == null)
                {
                    throw new Exception($"Shift not found for id : {id}");

                }
                var getShiftObject = new GetShiftDto(shift.Id, shift.ShiftName, shift.ShiftCode, shift.IsActive);
                return getShiftObject;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetShiftDto> UpdateShiftAsync(long id, UpdateShiftDto shiftDto)
        {
            try
            {
                var oldShift = await _repository.GetAsync(id);

                if (oldShift == null)
                {
                    throw new Exception($"Shift not found for id : {id}");

                }
                oldShift.ShiftName = shiftDto.ShiftName;
                oldShift.ShiftCode = shiftDto.ShiftName.ToUpper().Substring(0, 1);
                oldShift.UpdatedAt = DateTime.Now;
                oldShift.UpdatedBy = shiftDto.UpdatedBy;
                oldShift.IsActive = shiftDto.IsActive;

                await _repository.UpdateAsync(oldShift);

                var updateShiftObject = new GetShiftDto(oldShift.Id, oldShift.ShiftName, oldShift.ShiftCode, oldShift.IsActive);
                return updateShiftObject;

            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("Cannot insert duplicate key row") == true ||
                    ex.InnerException?.Message.Contains("UNIQUE constraint failed") == true)
                {
                    throw new Exception("This Shift already exists.");
                }

                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
