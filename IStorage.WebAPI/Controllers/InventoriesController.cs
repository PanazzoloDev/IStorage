using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IStorage.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class InventoriesController : ControllerBase
{
    private readonly IInventoryService _service;

    public InventoriesController(IInventoryService service)
    {
        _service = service;
    }

    [HttpPost("query")]
    public async Task<ActionResult> GetPaged(
        int pageNumber = 1,
        int pageSize = 50)
    //[FromBody] IEnumerable<FilterExpression>? filters = null)
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetById(long id)
    {
        return Ok(await _service.GetByIdAsync(id));
    }

    [HttpPost]

    public async Task<ActionResult> Create(NewInventoryModel model)
    {
        return Ok( _service.CreateAsync(model));
    }

    [HttpPut]
    public async Task<ActionResult> Update(UpdateInventoryModel model)
    {
        return Ok(_service.UpdateAsync(model));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        return Ok(_service.DeleteAsync(id));
    }
}
