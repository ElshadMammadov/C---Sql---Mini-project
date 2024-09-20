using Domain.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Category category)
        {
            Console.WriteLine("isledi");
        }
    }
}
