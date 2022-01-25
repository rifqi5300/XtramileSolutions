using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XtramileSolutions.AppDomain.Entities
{
    public class Cities
    {
        [Key]
        public string CityName { get; set; }
        public string CountryName { get; set; }        
    }
}
