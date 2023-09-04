using MediatR;
using Users.Entities;

namespace Users.Queries;

public record GetUsersQuery():IRequest<IEnumerable<User>>;
