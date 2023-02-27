using CarsApp.DataBase.Repositories;
using CarsApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarsApp.Controllers;

[Authorize]
[Route("cars/models")]
public class ModelController : ControllerBase
{
    private readonly ICarsRepositories<Model> _modelRepository = new ModelRepository();

    [ProducesResponseType(typeof(IEnumerable<Model>), 200)]
    [HttpGet("get")]
    public IActionResult Get()
    {
        var result = _modelRepository.GetAllModels();
        return Ok(result);
    }

    [HttpPost("post")]
    public IActionResult Post([FromBody] Model book)
    {
        _modelRepository.Create(book);
        return Ok();
    }

    [HttpPut("put")]
    public IActionResult Put(int id, [FromBody] Model model)
    {
        model.Id = id;
        _modelRepository.Update(model);
        return Ok();
    }

    [HttpDelete("delete")]
    public IActionResult Delete(int id)
    {
        _modelRepository.Delete(id);
        return Ok();
    }

    [HttpGet("group/get")]
    public IEnumerable<BrandModels> GetGroupModels()
    {
        var modelRepository = (ModelRepository)_modelRepository;
        return modelRepository.GetModelsGroupedByBrands();
    }
}
