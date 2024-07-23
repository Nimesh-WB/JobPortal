using JobPortal.Data;
using JobPortal.DTO;
using JobPortal.IRepository;
using JobPortal.IServices;
using JobPortal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JobPortal.DTO.LanguageDto;

namespace JobPortal.Services
{
    public class LanguageServices : ILanguageServices
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageServices(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<GetLanguageDto> CreateLanguageAsync(CreateLanguageDto createLanguageDto)
        {
            try
            {
                var language = await _languageRepository.CreateAsync(new Language()
                {
                    LanguageName = createLanguageDto.LanguageName,
                    LanguageCode = createLanguageDto.LanguageCode,
                    CreatedBy = createLanguageDto.CreatedBy,
                    UpdatedBy = createLanguageDto.CreatedBy,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });

                var res = new GetLanguageDto(language.Id, language.LanguageName, language.LanguageCode, language.IsActive);
                return res;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("Cannot insert duplicate key row") == true ||
                    ex.InnerException?.Message.Contains("UNIQUE constraint failed") == true)
                {
                    throw new Exception("This Language already exists.");
                }
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteLanguageAsync(long id)
        {
            try
            {
                var oldLanguage = await _languageRepository.GetAsync(id);
                if (oldLanguage == null)
                {
                    throw new Exception($"No Language found for id : {id}");
                }

                var res = await _languageRepository.DeleteAsync(oldLanguage);
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<GetLanguageDto>> GetLanguageAsync()
        {
            try
            {
                var languages = await _languageRepository.GetAllAsync();

                var languageDto = languages.Select(language => new GetLanguageDto(
                    language.Id,
                    language.LanguageName,
                    language.LanguageCode,
                    language.IsActive
                ));

                return languageDto.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetLanguageDto> GetLanguageById(long id)
        {
            try
            {
                var language = await _languageRepository.GetAsync(id);
                if (language == null)
                {
                    throw new Exception($"No Language found for id : {id}");
                }

                var res = new GetLanguageDto(language.Id, language.LanguageName, language.LanguageCode, language.IsActive);
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GetLanguageDto> UpdateLanguageAsync(long id, UpdateLanguageDto updateLanguageDto)
        {
            try
            {
                var oldLanguage = await _languageRepository.GetAsync(id);
                if (oldLanguage == null)
                {
                    throw new Exception($"No Language found for id : {id}");
                }

                oldLanguage.LanguageName = updateLanguageDto.LanguageName;
                oldLanguage.LanguageCode = updateLanguageDto.LanguageCode;
                oldLanguage.IsActive = updateLanguageDto.IsActive ? updateLanguageDto.IsActive : true;
                oldLanguage.UpdatedBy = updateLanguageDto.UpdatedBy;
                oldLanguage.UpdatedAt = DateTime.Now;

                await _languageRepository.UpdateAsync(oldLanguage);

                var res = new GetLanguageDto(oldLanguage.Id, oldLanguage.LanguageName, oldLanguage.LanguageCode, oldLanguage.IsActive);
                return res;
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("Cannot insert duplicate key row") == true ||
                    ex.InnerException?.Message.Contains("UNIQUE constraint failed") == true)
                {
                    throw new Exception("This Language already exists.");
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
