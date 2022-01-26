using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XtramileSolutions.Infrastructure.Data;
using XtramileSolutions.AppDomain.Entities;
using XtramileSolutions.Application.Implementations.Logics;
using System.Linq;

namespace XtramileUnitTests.Logics
{
    [TestClass]
    public class GeneralLogicsTest
    {
        [TestMethod]
        public void ConvertFahrenheitToCelcius_ShouldReturnsCorrectly()
        {
            GeneralLogics generalLogics = new GeneralLogics();
            var celcius = generalLogics.ConvertFahrenheitToCelcius(68);

            Assert.AreEqual(20, celcius);
        }
    }
}
