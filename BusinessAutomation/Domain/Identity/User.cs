using Microsoft.AspNetCore.Identity;

namespace BusinessAutomation.Domain.Identity
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
