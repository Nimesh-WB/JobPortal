﻿using JobPortal.Data;
using JobPortal.IRepository;
using JobPortal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Repository
{
    public class EmploymentTypeRepository : Repository<EmploymentType>, IEmploymentTypeRepository
    {
        public EmploymentTypeRepository(JobPortalDbContext dbcontext) : base(dbcontext)
        {
        }
    }
}
