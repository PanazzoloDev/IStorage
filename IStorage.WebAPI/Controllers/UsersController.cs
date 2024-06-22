using IStorage.Application.Interfaces;
using IStorage.Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SRferramentaria_csharp.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpPost("query")]
    public ActionResult GetPaged(
        int pageNumber = 1,
        int pageSize = 50)
        //[FromBody] IEnumerable<FilterExpression>? filters = null)
    {
        return Ok(_service.GetAllAsync());
    }

    [HttpGet("{id}")]
    public ActionResult GetById(long id)
    {
        return Ok(_service.GetByIdAsync(id));
    }

    [HttpPost]
    [AllowAnonymous]
    public ActionResult Create(NewUserModel model)
    {
        return Ok(_service.CreateAsync(model));
    }

    [HttpPut]
    public ActionResult Update(UpdateUserModel model)
    {    
        return Ok(_service.UpdateAsync(model));
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(long id)
    {
        return Ok(_service.DeleteAsync(id));
    }
}
