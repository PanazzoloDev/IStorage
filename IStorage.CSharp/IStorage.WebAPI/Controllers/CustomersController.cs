using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace IStorage.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomersController(ICustomerService service)
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

    public async Task<ActionResult> Create(NewCustomerModel model)
    {
        return Ok(_service.CreateAsync(model));
    }

    [HttpPut]
    public async Task<ActionResult> Update(UpdateCustomerModel model)
    {
        return Ok(_service.UpdateAsync(model));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
        return Ok(_service.DeleteAsync(id));
    }
}
