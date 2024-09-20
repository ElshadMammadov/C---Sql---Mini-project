using Domain.Entities;
using Service.Services.Interfaces;

namespace Mini_Layihe
{
    internal class ProductService : IProductService
    {
        public ProductService(object productRepository)
        {
            ProductRepository = productRepository;
        }

        public object ProductRepository { get; }

        public Task CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> FilterByCategoryNameAsync(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllWithCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
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

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}