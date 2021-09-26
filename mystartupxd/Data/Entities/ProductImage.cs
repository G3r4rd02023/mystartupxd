﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        // TODO: Change the path when publish
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
           //: $"https://localhost:44341{ImageUrl[1..]}";
            : $"https://mystartup.azurewebsites.net{ImageUrl.Substring(1)}";

        public Product Product { get; set; }
    }
}
