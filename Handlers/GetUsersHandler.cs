using MediatR;
using Microsoft.EntityFrameworkCore;
using Users.Contexts;
using Users.Entities;
using Users.Queries;

namespace Users.Handlers;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, IEnumerable<User>>
{
    private readonly UserContext _context;

    public GetUsersHandler(UserContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> Handle(
        GetUsersQuery request,
        CancellationToken cancellationToken
    )
    {

        return await _context.Users.ToListAsync(cancellationToken);
    }
}
