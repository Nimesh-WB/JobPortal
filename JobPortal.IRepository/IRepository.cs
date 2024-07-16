﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(long id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(long id,T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
