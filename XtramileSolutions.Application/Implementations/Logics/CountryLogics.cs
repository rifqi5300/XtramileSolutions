using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Interfaces.Logics;
using XtramileSolutions.Application.Interfaces.Data;
using XtramileSolutions.Application.Models;
using System.Linq;

namespace XtramileSolutions.Application.Implementations.Logics
{
    public class CountryLogics: ICountryLogics
    {
        private readonly IXtramileSolutionDbContext _xtramileSolutionDbContext;

        public CountryLogics(IXtramileSolutionDbContext xtramileSolutionDbContext)
        {
            _xtramileSolutionDbContext = xtramileSolutionDbContext;
        }

        public List<Countries> GetAll()
        {
            return _xtramileSolutionDbContext.Countries.Select(a => new Countries {CountryName = a.CountryName}).ToList();            
        }

        public string GetCountryNameByCity(string cityName)
        {
            return _xtramileSolutionDbContext.Cities.Single(x => x.CityName == cityName).CountryName;            
        }
    }
}
