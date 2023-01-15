using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.ApplicationLayer.Features.ProductFeature.Command.CreateProduct;
using Test.ApplicationLayer.Features.ProductFeature.Query.GetAllProduct;

namespace Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductRequest request)
        {
            CreateProductResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct ()
        {
            GetAllProductRequest request = new (); 
            GetAllProductResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
