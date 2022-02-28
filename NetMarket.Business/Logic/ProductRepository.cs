using NetMarket.Core.Entities;
using NetMarket.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMarket.Business.Logic
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
