using mystartupxd.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mystartupxd.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country
                {
                    Name = "Honduras",
                    Cities = new List<City>                                   
                        {
                            new City { Name = "Tegucigalpa" },
                            new City { Name = "San Pedro Sula" },
                            new City { Name = "La Ceiba" }
                        }                    
                });
                _context.Countries.Add(new Country
                {
                    Name = "USA",
                    Cities = new List<City>
                        {
                            new City { Name = "New York" },
                            new City { Name = "Los Angeles" },
                            new City { Name = "Chicago" }
                        }
                
                });
                _context.Countries.Add(new Country
                {
                    Name = "España",
                    Cities = new List<City>
                        {
                            new City { Name = "Madrid" },
                            new City { Name = "Barcelona" },
                            new City { Name = "Sevilla" }
                        }

                });
                await _context.SaveChangesAsync();
            }
        }

    }
}
