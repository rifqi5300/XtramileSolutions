using Microsoft.EntityFrameworkCore;
using System;
using XtramileSolutions.Infrastructure.Data;
using Xunit;

using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.InMemory;
using XtramileSolutions.AppDomain.Entities;

using XtramileSolutions.Application.Implementations.Logics;
using System.Linq;
using XtramileSolutions.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace XtramileSolutions.Test.Api
{
    
    public class HomeControllerTest
    {
        private XtramileSolutionDbContext _xtramileSolutionDbContext;

        public HomeControllerTest()
        {
            _xtramileSolutionDbContext = new XtramileSolutionDbContext(new DbContextOptionsBuilder<XtramileSolutionDbContext>().UseInMemoryDatabase(databaseName: "XtramileSolutions").Options);
        }

        [Fact]
        public void GetCountries_ShouldReturnCorrectResultCount()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Countries.Add(new Countries
                {
                    CountryName = "Malaysia"
                });
                context.Countries.Add(new Countries
                {
                    CountryName = "Singapore"
                });
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);
                CityLogics cityLogics = new CityLogics(context);
                GeneralLogics generalLogics = new GeneralLogics();

                var controller = new HomeController(countryLogics, cityLogics, generalLogics);
                var result = controller.GetCountries() as OkObjectResult;

                Assert.IsType<List<XtramileSolutions.Application.Models.Countries>>(result.Value);

                var items = result.Value as List<XtramileSolutions.Application.Models.Countries>;

                Assert.Equal(2, items.Count);

            }
        }

        [Fact]
        public void GetCities_ShouldReturnCorrectResultCount()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Cities.Add(new Cities
                {
                    CityName = "Sumberbaru",
                    CountryName = "Indonesia"
                });
                context.Cities.Add(new Cities
                {
                    CityName= "Sumberanyar",
                    CountryName = "Indonesia"
                });
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);
                CityLogics cityLogics = new CityLogics(context);
                GeneralLogics generalLogics = new GeneralLogics();

                var controller = new HomeController(countryLogics, cityLogics, generalLogics);
                var result = controller.GetCities() as OkObjectResult;

                Assert.IsType<List<XtramileSolutions.Application.Models.Cities>>(result.Value);

                var items = result.Value as List<XtramileSolutions.Application.Models.Cities>;

                Assert.Equal(2, items.Count);
            }
        }

        [Fact]
        public void GetCitiesByCountry_ShouldReturnCorrectly()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Cities.Add(new Cities
                {
                    CityName = "Bangkok",
                    CountryName = "Thailand"
                });
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);
                CityLogics cityLogics = new CityLogics(context);
                GeneralLogics generalLogics = new GeneralLogics();

                var controller = new HomeController(countryLogics, cityLogics, generalLogics);
                var result = controller.GetCitiesByCountry("Thailand") as OkObjectResult;

                Assert.IsType<List<XtramileSolutions.Application.Models.Cities>>(result.Value);

                var items = result.Value as List<XtramileSolutions.Application.Models.Cities>;

                Assert.Equal("Bangkok", items.Single().CityName);
                context.Cities.Remove(context.Cities.Single(a => a.CityName == "Bangkok" && a.CountryName == "Thailand"));
                context.SaveChanges();
            }
        }

        [Fact]
        public void GetCountryNameByCity_ShouldReturnCorrectly()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                context.Cities.Add(new Cities
                {
                    CityName = "Krok Phra",
                    CountryName = "Thailand"
                });
                context.SaveChanges();

                CountryLogics countryLogics = new CountryLogics(context);
                CityLogics cityLogics = new CityLogics(context);
                GeneralLogics generalLogics = new GeneralLogics();

                var controller = new HomeController(countryLogics, cityLogics, generalLogics);
                var result = controller.GetCountryNameByCity("Krok Phra") as OkObjectResult;

                Assert.IsType<string>(result.Value);

                var item = result.Value.ToString();

                Assert.Equal("Thailand", item);

                context.Cities.Remove(context.Cities.Single(a => a.CityName == "Krok Phra" && a.CountryName == "Thailand"));
                context.SaveChanges();
            }
        }

        [Fact]
        public void ConvertFahrenheitToCelcius_ShouldReturnCorrectly()
        {
            using (var context = _xtramileSolutionDbContext)
            {
                CountryLogics countryLogics = new CountryLogics(context);
                CityLogics cityLogics = new CityLogics(context);
                GeneralLogics generalLogics = new GeneralLogics();

                var controller = new HomeController(countryLogics, cityLogics, generalLogics);
                var result = controller.ConvertFahrenheitToCelcius(68) as OkObjectResult;

                Assert.IsType<double>(result.Value);

                var item = Convert.ToDouble(result.Value.ToString());

                Assert.Equal(20, item);
            }
        }



    }
}
