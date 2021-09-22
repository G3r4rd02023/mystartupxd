using Microsoft.AspNetCore.Http;
using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Models
{
    public class CountryViewModel:Country
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
