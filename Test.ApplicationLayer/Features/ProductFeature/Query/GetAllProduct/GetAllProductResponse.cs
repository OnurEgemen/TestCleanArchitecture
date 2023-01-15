using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.DomainLayer.Entities;

namespace Test.ApplicationLayer.Features.ProductFeature.Query.GetAllProduct
{
    public class GetAllProductResponse
    {
        public IList<Product> Products { get; set; }
    }
}
