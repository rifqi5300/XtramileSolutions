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
    public class CityLogicsTest
    {
        private XtramileSolutionDbContext _xtramileSolutionDbContext;
        
        public CityLogicsTest()
        {
            _xtramileSolutionDbContext = new XtramileSolutionDbContext(new DbContextOptionsBuilder<XtramileSolutionDbContext>().UseInMemoryDatabase(databaseName: "XtramileSolutions").Options);
        }

        [TestMethod]
        public void GetAll_ShouldReturnsCorrectCountofCityList()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Cities.Add(new Cities
                {
                    CityName = "Deli Tua",
                    CountryName = "Indonesia"
                });
                context.Cities.Add(new Cities
                {
                    CityName = "Bireun",
                    CountryName = "Indonesia"
                });
                context.Cities.Add(new Cities
                {
                    CityName = "Binjai",
                    CountryName = "Indonesia"
                });
                context.SaveChanges();

                CityLogics cityLogics = new CityLogics(context);

                var cityList = cityLogics.GetAll();
                Assert.AreEqual(3, cityList.Count);
            }
        }

        [TestMethod]
        public void GetCitiesByCountryCode_ShouldReturnsCorrectly()
        {
            using (var context = _xtramileSolutionDbContext)
            {

                context.Cities.Add(new Cities
                {
                    CityName = "London",
                    CountryName = "United Kingdom"
                });
                context.SaveChanges();

                CityLogics cityLogics = new CityLogics(context);

                var cityList = cityLogics.GetCitiesByCountryCode("United Kingdom");
                Assert.AreEqual("London", cityList.Select(a=>a.CityName).SingleOrDefault());

                context.Dispose();
            }
        }
















    }
}
