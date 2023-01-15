using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationLayer.Features.ProductFeature.Command.CreateProduct;
using Test.DomainLayer.Entities;

namespace Test.ApplicationLayer.Services
{
    public interface IProductService
    {
        Task Create(CreateProductRequest request);
        IQueryable<Product> GetAll();
    }
}
