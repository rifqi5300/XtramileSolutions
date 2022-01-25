using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.AppDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace XtramileSolutions.Application.Interfaces.Data
{
    public interface IXtramileSolutionDbContext
    {
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
    }
}
