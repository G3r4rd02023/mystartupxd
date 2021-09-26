using mystartupxd.Data.Entities;
using mystartupxd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Helpers
{
    public interface IConverterHelper
    {
       

        Category ToCategory(CategoryViewModel model, string path, bool isNew);

        CategoryViewModel ToCategoryViewModel(Category category);

        Task<Product> ToProductAsync(ProductViewModel model, bool isNew, string path);

        ProductViewModel ToProductViewModel(Product product);
    }
}
