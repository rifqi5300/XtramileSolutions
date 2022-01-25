using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Interfaces.Data;
using XtramileSolutions.AppDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace XtramileSolutions.Infrastructure.Data
{
    public class XtramileSolutionDbContext: DbContext, IXtramileSolutionDbContext
    {
        public XtramileSolutionDbContext(DbContextOptions<XtramileSolutionDbContext> options) : base(options) {  }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
    }
}
