using CarsApp.DataBase.Repositories;
using CarsApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarsApp.Controllers;

[Authorize]
[Route("cars/brands")]
public class BrandController : ControllerBase
{
    private readonly ICarsRepositories<Brand> _brandRepository = new BrandRepository();
    
    [ProducesResponseType(typeof(IEnumerable<Brand>), 200)]
    [HttpGet("get")]
    public IActionResult Get()
    {
        var result = _brandRepository.GetAllModels();
        return Ok(result);
    }

    [HttpPost("post")]
    public IActionResult Post([FromBody] Brand book)
    {
        _brandRepository.Create(book);
        return Ok();
    }

    [HttpPut("put")]
    public IActionResult Put(int id, [FromBody] Brand model)
    {
        model.Id = id;
        _brandRepository.Update(model);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(int id)
    {
        _brandRepository.Delete(id);
        return Ok();
    }
}
