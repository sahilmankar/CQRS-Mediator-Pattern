using MediatR;
using Microsoft.EntityFrameworkCore;
using Users.Contexts;
using Users.Entities;
using Users.Queries;

namespace Users.Handlers;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User?>
{
    private readonly UserContext _context;

    public GetUserByIdHandler(UserContext context)
    {
        _context = context;
    }

    public async  Task<User?> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
       var user=await _context.Users.FindAsync(request.Id,cancellationToken);
       return user;
    }
}
