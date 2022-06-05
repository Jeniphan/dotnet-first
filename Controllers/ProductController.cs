using Microsoft.AspNetCore.Mvc;

namespace dotnet_first.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
  [HttpGet]
  public ActionResult<List<string>> GetProduct()
  {
    var products = new List<string>();
    products.Add("VueJS");
    products.Add("Flutter");
    products.Add("React");

    return Ok(products);
  }
}
