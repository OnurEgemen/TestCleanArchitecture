using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationLayer.Features.ProductFeature.Command.CreateProduct;
using Test.ApplicationLayer.Services;
using Test.DomainLayer.Entities;
using Test.PersistanceLayer.Context;

namespace Test.PersistanceLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(CreateProductRequest request)
        {
            Product product = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Set<Product>().AsQueryable();
        }
    }
}
