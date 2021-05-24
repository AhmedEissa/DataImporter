using System.Threading.Tasks;
using DataImporter.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DataImporter.Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductController : ControllerBase
  {
    public ProductController(ILogger<ProductController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
      return Ok(_productService.GetByIdAsync(id));
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAllAsync());
    }

    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _productService;
  }
}
