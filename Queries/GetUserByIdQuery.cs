using MediatR;
using Users.Entities;

namespace Users.Queries;

public record GetUserByIdQuery(int Id):IRequest<User>;
