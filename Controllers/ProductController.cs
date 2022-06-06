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

  [HttpGet("{id}")]
  public ActionResult GetTProductById(int id)
  {
    return Ok(new { productId = id, name = "Test" });
  }

  [HttpGet("search/{id}/{category}")]
  public ActionResult GetQueryProductById(int id, string category)
  {
    return Ok(new { productId = id, name = "Test", catory = category });
  }

  [HttpGet("query/product")]
  public ActionResult QueryProductById(int id, string category)
  {
    return Ok(new { productId = id, name = "Test", catory = category });
  }

  [HttpPost]
  public ActionResult<Product> AddProduct([FromBody] Product product) //FromBody and FromeForm
  {
    return Ok(product);
  }

  [HttpPut("{id}")] // ../product/1111
  public ActionResult PutUpdataProductById(int id, [FromBody] Product product)
  {
    if (id != product.id)
    {
      return BadRequest();
    }

    if (id != 1111)
    {
      return NotFound();
    }

    return Ok(product);
  }

  [HttpDelete("{id}")]
  public ActionResult<Product> DeleteProductById(int id)
  {
    if (id != 1111)
    {
      return NotFound();
    }
    return NoContent();
  }


  public class Product
  {
    public int id { get; set; }
    public string name { get; set; }
    public int price { get; set; }
  }

}