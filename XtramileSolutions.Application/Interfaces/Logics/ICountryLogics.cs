using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Models;

namespace XtramileSolutions.Application.Interfaces.Logics
{
    public interface ICountryLogics
    {
        List<Countries> GetAll();

        string GetCountryNameByCity(string cityName);
    }
}
