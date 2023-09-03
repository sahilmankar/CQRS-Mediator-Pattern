using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Users.Entities;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public required int Id { get; set; }

    [Column("imageurl")]
    public required string ImageUrl { get; set; }

    [Column("aadharid")]
    public required string AadharId { get; set; }

    [Column("firstname")]
    public required string FirstName { get; set; }

    [Column("lastname")]
    public required string LastName { get; set; }

    [Column("birthdate")]
    public required DateTime BirthDate { get; set; }

    [Column("gender")]
    public required string Gender { get; set; }

    [Column("email")]
    public required string Email { get; set; }

    [Column("contactnumber")]
    public required string ContactNumber { get; set; }
}


