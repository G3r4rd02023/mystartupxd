using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mystartupxd.Data;
using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Helpers
{
    public class CombosHelper:ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetComboCategories()
        {
            List<SelectListItem> list = _context.Categories.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = $"{t.Id}"
            })
               .OrderBy(t => t.Text)
               .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione una categoría...]",
                Value = "0"
            });

            return list;
        }

             

        public IEnumerable<SelectListItem> GetComboProducts()
        {
            List<SelectListItem> list = _context.Products.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = $"{t.Id}"
            })
                 .OrderBy(t => t.Text)
                 .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un Producto...]",
                Value = "0"
            });

            return list;
        }

    }
}
