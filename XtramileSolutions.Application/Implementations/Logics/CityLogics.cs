using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Interfaces.Logics;
using XtramileSolutions.Application.Interfaces.Data;
using XtramileSolutions.Application.Models;
using System.Linq;

namespace XtramileSolutions.Application.Implementations.Logics
{
    public class CityLogics : ICityLogics
    {
        private readonly IXtramileSolutionDbContext _xtramileSolutionDbContext;

        public CityLogics(IXtramileSolutionDbContext xtramileSolutionDbContext)
        { 
            _xtramileSolutionDbContext = xtramileSolutionDbContext;
        }

        public List<Cities> GetAll()
        {
            return _xtramileSolutionDbContext.Cities.Select(x => new Cities {CityName = x.CityName, CountryName = x.CountryName }).ToList();
        }

        public List<Cities> GetCitiesByCountryCode(string countryName)
        {
            return _xtramileSolutionDbContext.Cities.Where(a=>a.CountryName == countryName).Select(x => new Cities { CityName = x.CityName, CountryName = x.CountryName }).ToList();
        }

    }
}
