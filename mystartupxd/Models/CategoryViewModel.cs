using Microsoft.AspNetCore.Http;
using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Models
{
    public class CategoryViewModel : Category
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
