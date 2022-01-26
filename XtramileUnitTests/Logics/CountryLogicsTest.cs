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
    public class CountryLogicsTest
    {
        private XtramileSolutionDbContext _xtramileSolutionDbContext;

        public CountryLogicsTest()
        {
            _xtramileSolutionDbContext = new XtramileSolutionDbContext(new DbContextOptionsBuilder<XtramileSolutionDbContext>().UseInMemoryDatabase(databaseName: "XtramileSolutions").Options);
        }

        [TestMethod]
        public void GetAll_ShouldReturnsCorrectCountofCountryList()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Countries.Add(new Countries
                {
                    CountryName = "Indonesia"
                });
                context.Countries.Add(new Countries
                {
                    CountryName = "United Kingdom"
                });
                context.Countries.Add(new Countries
                {
                    CountryName = "USA"
                });
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);

                var countryList = countryLogics.GetAll();

                Assert.AreEqual(3, countryList.Count);
            }
        }

        [TestMethod]
        public void GetCountryNameByCity_ShouldReturnsCorrectly()
        {
            using (var context = _xtramileSolutionDbContext)
            {                
                context.Cities.Add(new Cities
                {
                    CityName = "Sumberpucung",
                    CountryName = "Indonesia"
                });
                context.SaveChanges();
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);

                var countryName = countryLogics.GetCountryNameByCity("Sumberpucung");

                Assert.AreEqual("Indonesia", countryName);
            }
        }


    }
}
