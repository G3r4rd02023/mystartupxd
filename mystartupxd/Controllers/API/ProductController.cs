﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mystartupxd.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .Where(p => p.IsActive));
        }
    }

}
