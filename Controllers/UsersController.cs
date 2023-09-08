using MediatR;
using Microsoft.AspNetCore.Mvc;
using Users.Entities;
using Users.Queries;

namespace Users.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> GetUsers(CancellationToken cancellationToken)
    {
        var users = await _mediator.Send(new GetUsersQuery(), cancellationToken);
        return users is not null ? Ok(users) : NotFound();
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetUserById(int id, CancellationToken cancellationToken)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(id), cancellationToken);
        return user is not null ? Ok(user) : NotFound();
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser(
        [FromBody] User user,
        CancellationToken cancellationToken
    )
    {
        var result = await _mediator.Send(new CreateUserCommand(user), cancellationToken);
        return Ok(result);
    }
}
