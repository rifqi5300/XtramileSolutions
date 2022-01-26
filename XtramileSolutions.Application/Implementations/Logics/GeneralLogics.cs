using System;
using System.Collections.Generic;
using System.Text;
using XtramileSolutions.Application.Interfaces.Logics;

namespace XtramileSolutions.Application.Implementations.Logics
{
    public class GeneralLogics : IGeneralLogics
    {
        public double ConvertFahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}
