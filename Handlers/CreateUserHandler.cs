using MediatR;
using Users.Contexts;
using Users.Queries;

namespace Users.Handlers;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly UserContext _context;

    public CreateUserHandler(UserContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        await _context.AddAsync(request.user, cancellationToken);
        return await _context.SaveChangesAsync(cancellationToken) > 0;
    }
}
