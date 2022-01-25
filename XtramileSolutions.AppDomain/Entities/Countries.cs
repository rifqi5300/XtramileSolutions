using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace XtramileSolutions.AppDomain.Entities
{
    public class Countries
    {
        [Key]
        public string CountryName { get; set; }
    }
}
