﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Models
{
    public class ProductViewModel:Product
    {
        [Display(Name = "Categoría")]
        [Range(1, int.MaxValue, ErrorMessage = "Seleccione una categoría.")]
        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

    }
}
