using Domain.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
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

        public Task<IEnumerable<Product>> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SortByCreatedDateAsync(bool ascending)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> SortWithPriceAsync(bool ascending)
        {
            throw new NotImplementedException();
        }
    }
}
