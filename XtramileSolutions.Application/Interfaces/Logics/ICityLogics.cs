using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Models;

namespace XtramileSolutions.Application.Interfaces.Logics
{
    public interface ICityLogics
    {
        List<Cities> GetAll();

        List<Cities> GetCitiesByCountryCode(string countryName);
    }
}
