using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository()
        {
            _context = new AppDbContext();
        }
        public async Task DeleteAsync(int opr)
        {
            if (opr == 1)
            {
                await _context.Set<Product>().OrderBy(m => m.CreatedDate).ToListAsync();
            }
            else
            {
                await _context.Set<Product>().OrderByDescending(m => m.CreatedDate).ToListAsync();
            }
        }

        public Task<IEnumerable<Product>> FilterByCategoryNameAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllWithCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SearchByColorAsync(string color)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> SearchByNameAsync(string name)
        {
            return await _context.Products.Where(m => m.Name.Trim().ToUpper().Contains(name.Trim().ToUpper())).
                                           ToListAsync();

        }

        public async Task<IEnumerable<Product>> SortByCreatedDateAsync(int opr)
        {
            if (opr == 1)
            {
                return await _context.Set<Product>().OrderBy(m => m.CreatedDate).ToListAsync();
            }
            else
            {
                return await _context.Set<Product>().OrderByDescending(m => m.CreatedDate).ToListAsync();
            }
        }

        public async Task<IEnumerable<Product>> SortWithPriceAsync(int opr)
        {
            if (opr == 1)
            {
                return await _context.Set<Product>().OrderBy(m => m.Price).ToListAsync();
            }
            else
            {
                return await _context.Set<Product>().OrderByDescending(m => m.Price).ToListAsync();
            }
        }
    }
}