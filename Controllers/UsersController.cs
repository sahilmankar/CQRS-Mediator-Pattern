using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Users.Contexts;
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
    public async Task<ActionResult> GetUsers(CancellationToken cancellationToken )
    {
        var users = await _mediator.Send(new GetUsersQuery(),cancellationToken);

        return Ok(users);
    }
}
