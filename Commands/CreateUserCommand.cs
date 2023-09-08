
using MediatR;
using Users.Entities;

namespace Users.Queries;

public record CreateUserCommand(User user):IRequest<bool>;
