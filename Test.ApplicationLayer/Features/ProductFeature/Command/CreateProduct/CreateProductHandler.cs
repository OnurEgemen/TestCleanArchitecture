using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ApplicationLayer.Services;

namespace Test.ApplicationLayer.Features.ProductFeature.Command.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        private readonly IProductService _productService;

        public CreateProductHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<CreateProductResponse> Handle(CreateProductRequest request, 
            CancellationToken cancellationToken)
        {
            await _productService.Create(request);
            return new CreateProductResponse {Message = "Kayıt başarıyla tamamlandı!"};
        }
    }
}
